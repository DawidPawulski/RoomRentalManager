<template>
    <b-navbar-nav>
        <b-button size="sm" class="my-2 my-sm-0" type="button">
            <b-nav-item><router-link :to="'/user/owner/' + UserID">Home</router-link></b-nav-item>
        </b-button>
        <b-button size="sm" class="my-2 my-sm-0" type="button">
            <b-nav-item><router-link to="/">Marketplace</router-link></b-nav-item>
        </b-button>
        <b-button size="sm" class="my-2 my-sm-0" type="button">
            <b-nav-item><router-link to="/all_tenants">All Tenants</router-link></b-nav-item>
        </b-button>
        <b-button size="sm" class="my-2 my-sm-0" type="button">
            <b-nav-item><router-link to="/new_apartment">Add Apartment</router-link></b-nav-item>
        </b-button>
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