<template>
    <div>
        <Navbar :UserRole="UserRole" :UserID="UserID" />
        <b-row align-h="center">
            <b-col cols="10">
                <ApartmentDetails :ApartmentList="ApartmentList"></ApartmentDetails>
            </b-col>
        </b-row>
    </div>
</template>

<script>
    import Navbar from '../components/Navbar';
    import ApartmentDetails from '../components/ApartmentDetails'

    export default {
        name: 'OwnerPage',
        components: {
            Navbar,
            ApartmentDetails
        },
        props: {

        },
        data() {
            return {
                UserRole: RegExp("UserRole" + "=([^;]+)").exec(document.cookie)[1],
                UserID: RegExp("UserID" + "=([^;]+)").exec(document.cookie)[1],
                ApartmentList: []
            }
        },
        methods: {
                        /* eslint-disable */
            getApartments() {
                const axios = require('axios')
                let url = "https://localhost:44311/api/Apartments/User?user_id=" + this.UserID
                axios.get(url)
                    .then((response) => {
                        console.log(response)
                        this.ApartmentList = response.data
                        return response
                    })
            }
        },
        mounted: function () {
            this.getApartments()
        }
    }
</script>

<style scoped>
</style>