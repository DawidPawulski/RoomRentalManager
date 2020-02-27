<template>
    <b-navbar-nav>
        <b-button-group>
            <b-button size="sm" class="my-2 my-sm-0" type="button" variant="dark">
                <b-nav-item><router-link :to="'/user/owner/' + UserID" style="color:white">Home</router-link></b-nav-item>
            </b-button>
            <p> </p>
            <b-button size="sm" class="my-2 my-sm-0" type="button" variant="dark">
                <b-nav-item><router-link to="/" style="color:white">Marketplace</router-link></b-nav-item>
            </b-button>
            <p> </p>
            <b-button size="sm" class="my-2 my-sm-0" type="button" variant="dark">
                <b-nav-item><router-link to="/all_tenants" style="color:white">All Tenants</router-link></b-nav-item>
            </b-button>
            <p> </p>
            <b-button size="sm" class="my-2 my-sm-0" type="button" variant="dark">
                <b-nav-item><router-link to="/new_apartment" style="color:white">Add Apartment</router-link></b-nav-item>
            </b-button>
        </b-button-group>

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