<template>
    <div>
    <Navbar :UserRole="UserRole" :UserID="UserID" />
    <div>
        <market :AdvertList="Adverts"></market>
    </div>
        </div>
</template>

<script>
    import Navbar from '../components/Navbar.vue';
    import MarketTable from '../components/MarketTable';

    export default {
        name: 'MainPage',
        data() {
            return {
                Adverts: [
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
                ],
                UserRole: RegExp("UserRole" + "=([^;]+)").exec(document.cookie)[1],
                UserID: RegExp("UserID" + "=([^;]+)").exec(document.cookie)[1]
            }

        },
        components: {
            'market': MarketTable,
            Navbar
        }

    }
</script>

<style scoped>
</style>