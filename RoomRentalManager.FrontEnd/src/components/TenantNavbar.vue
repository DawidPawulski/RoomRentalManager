<template>
    <b-navbar-nav>
        <b-nav-item><router-link :to="'/user/tenant/' + UserID">Home</router-link></b-nav-item>
        <b-nav-item><router-link to="/">Marketplace</router-link></b-nav-item>
        <b-nav-item><router-link to="/requests">Requests</router-link></b-nav-item>
    </b-navbar-nav>

</template>

<script>
        export default {
        name: "TenantNavbar",
        props: {
            UserID: String
        }
    }

</script>

<style scoped>
</style>