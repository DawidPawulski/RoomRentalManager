<template>
    <div>
        <b-row align-h="start">
            <b-column col="3">
                <div role="tablist">
                    <br />
                    <b-card no-body class="mb-1" v-for="apartment in ApartmentList" :key="apartment.id">
                        <div>
                            <b-button block href="#" v-on:click="getRooms(apartment.id, apartment)" variant="info">{{ apartment.street }}</b-button>
                        </div>
                        <!--<b-collapse :id="apartment.id" visible accordion="my-accordion" role="tabpanel">
                            <b-button type="button" v-if="apartmentRooms.length > 0" v-for="room in apartmentRooms" :key="room.id">
                                {{room.id}}
                            </b-button>
                        </b-collapse>-->


                    </b-card>

                </div>
            </b-column>
        </b-row>
        <b-row align-h="center">
            <b-column col="9" v-if="show" :key="columnKey">
                <DataBox :roomData="passedApartment"></DataBox>
                <b-tabs>
                    <b-tab v-if="apartmentRooms.length > 0" v-for="room in apartmentAllRooms" :key="room.id" :title="' Room ' + room.id.toString()">
                        <DataBox :roomData="room"></DataBox>
                        <div v-if="room.advertisement == null">
                            <b-form @submit="onSubmit">


                                <b-form-group id="input-group-1" label="Advertisement title:" label-for="input-1">
                                    <b-form-input id="input-1"
                                                  v-model="form.Title"
                                                  type="text"
                                                  required
                                                  placeholder="Title"></b-form-input>
                                </b-form-group>
                                <b-form-group id="input-group-2" label="Description:" label-for="input-1">
                                    <b-form-textarea id="input-2"
                                                     v-model="form.Description"
                                                     rows="3"
                                                     max-rows="6"
                                                     required
                                                     placeholder="Description"></b-form-textarea>
                                </b-form-group>
                                <b-button type="submit" variant="dark" v-on:click="form.RoomId = room.id">Submit</b-button>
                            </b-form>
                        </div>
                    </b-tab>
                </b-tabs>

            </b-column>
        </b-row>
    </div>
</template>

<script>
    import DataBox from './DataBox'

    export default {
        name: "ApartmentDetails",
        components: {
            DataBox
        },
        methods: {
            /* eslint-disable */
            onSubmit(evt) {
                evt.preventDefault();
                const axios = require('axios')
                let url = "https://localhost:44311/api/Advertisements"
                axios.post(url, {
                    "Title": this.form.Title,
                    "Description": this.form.Description,
                    "RoomId": parseInt(this.form.RoomId),
                    "CreationDate": new Date().toJSON()
                }).then(response => {
                    console.log(response)
                })
            },
            getRooms(apartmentId, apartment) {
                this.apartmentRooms = []
                this.passedRoom = {}
                const axios = require('axios')
                let url = 'https://localhost:44311/api/Rooms/byApartmentId?apartmentId=' + apartmentId.toString()
                this.passedRoom = apartment
                return axios.get(url, {
                    crossdomain: true,
                }).then(response => {
                    this.apartmentRooms = response.data
                    this.show = true
                    this.columnKey += 1
                })

            }
        },
        props: {
            ApartmentList: Array
        },
        data() {
            return {
                passedRoom: {},
                apartmentRooms: [],
                show: false,
                columnKey: 0,
                form: {
                    Title: '',
                    Description: '',
                    RoomId: '',
                }
            }
            // add tabs instead of collapse
        },
        computed: {
            passedApartment: function () {
                return this.passedRoom
            },
            apartmentAllRooms: function () {
                return this.apartmentRooms
            }
        }
    }
</script>

<style scoped>
</style>