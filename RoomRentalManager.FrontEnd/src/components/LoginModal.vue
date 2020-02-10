<template>
    <div>
        <b-modal id="LoginModal" title="BootstrapVue">
            <b-form @submit="onSubmit" v-if="show">


                <b-form-group id="input-group-1" label="Email:" label-for="input-1">
                    <b-form-input id="input-1"
                                  v-model="form.Email"
                                  type="email"
                                  required
                                  placeholder="email"></b-form-input>
                </b-form-group>
                <b-form-group id="input-group-2" label="Password:" label-for="input-1">
                    <b-form-input id="input-2"
                                  v-model="form.Password"
                                  type="password"
                                  required
                                  placeholder="password"></b-form-input>
                </b-form-group>



                <b-alert :show="dismissCountDown"
                         dismissible
                         fade
                         variant="alert"
                         @dismiss-count-down="countDownChanged">
                    Wrong Email or Password
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
                    Password: ''
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
                this.loginUser();
            },
            /* eslint-disable */

            loginUser() {
                const axios = require('axios');
                var url = "https://localhost:44311/api/Users/login?Email=" + this.form.Email + "&Password=" + this.form.Password;
                axios.get(url, {
                    "Email": this.form.Email,                   
                    "Password": this.form.Password
                })
                    .then(function (response) {
                        console.log(response);
                    })
                    .catch(function (error) {
                        console.log(error.response);
                        this.showAlert();
                    });
            }
        }
    }

</script>

<style scoped>
</style>