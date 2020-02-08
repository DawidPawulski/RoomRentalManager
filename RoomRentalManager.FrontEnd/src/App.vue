<template>
    <div id="app">
        <Navbar :UserRole="UserRole" :UserID="UserID"/>
        <Home msg="Hello world!" />
        <router-view></router-view>
    </div>
</template>

<script>
    import Home from './components/Home.vue';
    import Navbar from './components/Navbar.vue';

    export default {
        name: 'app',
        components: {
            Home,
            Navbar
        },
        data() {
            return {
                UserRole: RegExp("UserRole" + "=([^;]+)").exec(document.cookie)[1],
                UserID: 1
            }
        },
        mounted: function() {
            document.cookie = "UserRole=None"
        }
    };
</script>

<style>
</style>

