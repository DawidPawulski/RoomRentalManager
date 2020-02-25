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
                perPage: 1,
                currentPage: 1,
                // Note 'isActive' is left out and will not appear in the rendered table
                fields: [
                    {
                        key: 'date',
                        label: 'Date',
                        sortable: true
                    },
                    {
                        key: 'title',
                        label: 'Title',
                        sortable: true
                    },
                    {
                        key: 'image',
                        label: 'Photo',
                        sortable: false
                    }
                ],
                items: [
                    {
                        image: "img1",
                        title: "title1",
                        date: "1"
                    },
                    {
                        image: "img2",
                        title: "title2",
                        date: "2"
                    },
                    {
                        image: "img3",
                        title: "title3",
                        date: "3"
                    }
                ]
            }
        },
        methods: {
            getAdvertisements() {
                const axios = require('axios');
                let url = "https://localhost:44311/api/Advertisements";
                axios.get(url).then((response) => {
                    console.log(response)
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