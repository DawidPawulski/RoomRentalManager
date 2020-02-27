<template>
    <div>
        <b-row align-h="start">
            <b-column col="3">
                <div role="tablist">
                    <b-card no-body class="mb-1" v-for="apartment in ApartmentList" :key="apartment.id">
                        <div role="tab">
                            <b-button block href="#" v-b-toggle.accordion-apartment.id variant="info" v-on:click="getRooms(apartment.id, apartment)">{{ apartment.street }}</b-button>
                        </div>
                        <b-collapse :id="apartment.id" visible accordion="my-accordion" role="tabpanel">
                            <b-button type="button" v-if="apartmentRooms.length > 0" v-for="room in apartmentRooms" :key="room.id">
                                {{room.id}}
                            </b-button>
                        </b-collapse>
                        
                        
                    </b-card>

                </div>
            </b-column>

            <b-column col="9">
                <DataBox :roomData="passedRoom"></DataBox>
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
            getRooms(apartmentId, apartment) {
                const axios = require('axios')
                let url = 'https://localhost:44311/api/Rooms/byApartmentId?apartmentId=' + apartmentId.toString()
                this.passedRoom = apartment
                axios.get(url, {
                    crossdomain: true,
                }).then((response) => {
                    this.apartmentRooms = response.data
                })
            }
        },
        props: {
            ApartmentList: Array
        },
        data() {
            return {
                passedRoom: {
                    id: 1,
                    name: "aaaa"
                },
                apartmentRooms: []
            }
            // add tabs instead of collapse
        }
    }
</script>

<style scoped>
</style>