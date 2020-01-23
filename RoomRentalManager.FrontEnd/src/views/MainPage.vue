<template>
    <div><market :AdvertList="Adverts"></market></div>
</template>

<script>
    import MarketTable from '../components/MarketTable';

    export default {
        name: 'MainPage',
        data (){
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
            ]
            }
            
        },
        components: {
            'market': MarketTable
        }
    }
</script>

<style scoped>
</style>