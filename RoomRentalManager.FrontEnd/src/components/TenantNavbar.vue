<template>
    <b-navbar-nav>
        <b-nav-item><router-link to="/">Home</router-link></b-nav-item>
        <b-nav-item><router-link to="/new_apartment">newapartmentpage</router-link></b-nav-item>
        <b-nav-item><router-link to="/advert/2">AddPage</router-link></b-nav-item>
    </b-navbar-nav>

</template>

<script>
        export default {
            name: "TenantNavbar"
    }
</script>

<style scoped>
</style>