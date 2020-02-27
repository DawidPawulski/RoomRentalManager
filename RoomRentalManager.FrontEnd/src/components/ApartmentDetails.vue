<template>
    <div>
        <b-row align-h="start">
            <b-column col="3">
                <div role="tablist">
                    <b-card no-body class="mb-1" v-for="apartment in ApartmentList" :key="apartment.id">
                        <div role="tab">
                            <b-button block href="#" v-b-toggle.accordion-1 variant="info" v-on:click="passedRoom = apartment">{{ apartment.street }}</b-button>
                        </div>
                        <b-collapse id="accordion-1" visible accordion="my-accordion" role="tabpanel">
                            <b-button type="button" v-for="room in apartment.room" :key="room.id">
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

        },
        props: {
            ApartmentList: Array
        },
        data() {
            return {
                passedRoom: {
                    id: 1,
                    name: "aaaa"
                }
            }
        }
    }
</script>

<style scoped>
</style>