<template>
    <div id="app">
        <Navbar/>
        <Home msg="Hello world!" />
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
        }
    };
</script>

<style>
</style>

