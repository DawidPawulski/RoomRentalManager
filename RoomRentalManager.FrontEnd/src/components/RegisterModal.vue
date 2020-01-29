<template>
    <div>
        <b-modal id="RegisterModal" title="BootstrapVue">
            <b-form @submit="onSubmit" v-if="show">


                <b-form-group id="input-group-1" label="Your Name:" label-for="input-1">
                    <b-form-input id="input-1"
                                  v-model="form.FirstName"
                                  required
                                  placeholder="First Name"></b-form-input>
                    <b-form-input id="input-2"
                                  v-model="form.LastName"
                                  required
                                  placeholder="Last Name"></b-form-input>
                </b-form-group>

                <b-form-group id="input-group-2"
                              label="Contact Information:"
                              label-for="input-3">
                    <b-form-input id="input-3"
                                  v-model="form.Email"
                                  type="email"
                                  required
                                  placeholder="Enter email"></b-form-input>
                    <b-form-input id="input-4"
                                  v-model="form.PhoneNumber"
                                  type="tel"
                                  placeholder="Phone Number"></b-form-input>
                </b-form-group>

                <b-form-group id="input-group-3"
                              label="Document ID number:"
                              label-for="input-5">
                    <b-form-input id="input-5"
                                  v-model="form.DocumentID"
                                  type="text"
                                  required
                                  placeholder="Enter Document ID"></b-form-input>
                </b-form-group>



                <b-form-group id="input-group-4">
                    <b-form-radio-group v-model="form.UserRole" id="radio-4">
                        <b-form-radio v-model="form.UserRole" name="UserType" value="Tenant">Tenant</b-form-radio>
                        <b-form-radio v-model="form.UserRole" name="UserType" value="Owner">Owner</b-form-radio>
                    </b-form-radio-group>
                </b-form-group>

                <b-form-group id="input-group-6"
                              label="Password:"
                              label-for="input-6">
                    <b-form-input id="input-6"
                                  v-model="form.Password"
                                  type="password"
                                  required></b-form-input>
                </b-form-group>

                <b-alert :show="dismissCountDown"
                         dismissible
                         fade
                         variant="alert"
                         @dismiss-count-down="countDownChanged">
                    Email already in use
                </b-alert>
                <b-button type="submit" variant="primary">Submit</b-button>
            </b-form>

        </b-modal>
    </div>
</template>

<script>

    export default {
        name: "RegisterModal",
        data() {
            return {
                form: {
                    Email: '',
                    FirstName: '',
                    LastName: '',
                    PhoneNumber: '',
                    DocumentID: '',
                    UserRole: '',
                    Password: '',
                    Hash: ''
                },
                show: true,
                dismissSecs: 5,
                dismissCountDown: 0
            }
        },
        methods: {
            /* eslint-disable */
            countDownChanged(dismissCountDown) {
                this.dismissCountDown = dismissCountDown
            },
            showAlert() {
                this.dismissCountDown = this.dismissSecs
            },

            onSubmit(evt) {
                evt.preventDefault();
                this.checkIfEmailUsed().then((emailInUse) => {
                    if (emailInUse === true) {
                        this.showAlert();
                        console.log("email in use");
                    }
                    else {
                        const bcrypt = require('bcryptjs');
                        this.form.Hash = bcrypt.hashSync(this.form.Password, 10);
                        this.registerUser()
                    }
                });
            },
            /* eslint-disable */
            checkIfEmailUsed() {
                const axios = require('axios');
                let url = 'https://localhost:44311/api/Users/byEmail?Email=' + this.form.Email;
                return axios.get(url)
                    .then(function (response) {
                        console.log(response)
                        return true;
                    })
                    .catch(function (error) {
                        return false;
                    })

            },
            registerUser() {
                const axios = require('axios');
                var url = "https://localhost:44311/api/Users"
                axios.post(url, {
                    "Email": this.form.Email,
                    "FirstName": this.form.FirstName,
                    "LastName": this.form.LastName,
                    "Phone": this.form.PhoneNumber,
                    "PersonalDocumentNumber": this.form.DocumentID,
                    "Role": this.form.UserRole,
                    "Password": this.form.Hash,
                })
                    .then(function (response) {
                        console.log(response);
                    })
                    .catch(function (error) {
                        console.log(error.response);
                    });
            }
        }
    }

</script>

<style scoped>
</style>