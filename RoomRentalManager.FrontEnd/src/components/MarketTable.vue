<template>
    <div>
        <b-table striped hover :items="items" :fields="fields" id="AdsTable" :per-page="perPage" :current-page="currentPage"></b-table>
        <b-pagination v-model="currentPage"
                      :total-rows="rows"
                      :per-page="perPage"
                      aria-controls="AdsTable">

        </b-pagination>
    </div>
</template>

<script>
    export default {
        name: 'MarketTable',
        props: {
            AdvertList: Array
        },
        computed: {
            rows() {
                return this.items.length
            }
        },
        data() {
            return {
                perPage: 5,
                currentPage: 1,
                fields: [
                    {
                        key: 'creationDate',
                        label: 'Date',
                        sortable: true
                    },
                    {
                        key: 'title',
                        label: 'Title',
                        sortable: true
                    },
                    {
                        key: 'description',
                        label: 'Description',
                        sortable: false
                    }
                ],
                items: [
                ]
            }
        },
        methods: {
            /* eslint-disable */
            getAdvertisements() {
                const axios = require('axios');
                let url = "https://localhost:44311/api/Advertisements";
                return axios.get(url).then(response => {
                    console.log(response)
                    this.items = response.data
                })
            }
        },
        mounted: function () {
            this.$nextTick(() => {
                this.getAdvertisements();
            })
        }
    };
</script>

<style scoped>
</style>