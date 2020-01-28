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
                              label-for="input-5">
                    <b-form-input id="input-5"
                                  v-model="form.Password"
                                  type="password"
                                  required></b-form-input>
                </b-form-group>

                <b-button type="submit" variant="primary">Submit</b-button>
            </b-form>
            <b-card class="mt-3" header="Form Data Result">
                <pre class="m-0">{{ form }}</pre>
            </b-card>
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
                show: true
            }
        },
        methods: {
            onSubmit(evt) {
                evt.preventDefault()
                const bcrypt = require('bcryptjs');

                this.form.Hash = bcrypt.hashSync(this.form.Password, 10);
                alert(JSON.stringify(this.form))
            }
            }
        }
    
</script>

<style scoped>
</style>