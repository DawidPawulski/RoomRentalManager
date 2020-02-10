<template>
    <b-navbar-nav>
        <b-nav-item><router-link :to="'/user/owner/' + UserID">Home</router-link></b-nav-item>
        <b-nav-item><router-link to="/">Marketplace</router-link></b-nav-item>
        <b-nav-item><router-link to="/all_tenants">All Tenants</router-link></b-nav-item>
    </b-navbar-nav>
</template>

<script>
    export default {
        name: "OwnerNavbar",
        props: {
            UserID: String
        }
    }
</script>

<style scoped>
</style>