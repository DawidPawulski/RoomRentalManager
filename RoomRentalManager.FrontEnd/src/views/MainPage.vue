<template>
    <div><market :Projects="projects"></market></div>
</template>

<script>
    import MarketTable from '../components/MarketTable';
    import axios from 'axios';
    
    export default {
        name: 'MainPage',
        data() {
            return {
                projects: null
            }
            
        },

        mounted () {
            axios
                .get('https://localhost:5001/api/Advertisements')
                   .then(response => (this.projects = response.data))
        },

        components: {
            'market': MarketTable
        }
    }
</script>

<style scoped>
</style>