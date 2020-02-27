<template>
    <b-nav-form>
        <b-button-group>
            <b-button size="sm" class="my-2 my-sm-0" type="button" variant="dark">Edit Profile</b-button>
            <p> </p>
            <b-button size="sm" class="my-2 my-sm-0" type="button" variant="dark">Messages</b-button>
            <p> </p>
            <b-button size="sm" class="my-2 my-sm-0" type="button" variant="dark">Notifications</b-button>
            <p> </p>
            <b-button size="sm" class="my-2 my-sm-0" type="button" v-on:click="logout" variant="dark">Logout</b-button>
        </b-button-group>
    </b-nav-form>

</template>

<script lang="ts">
    export default {
        name: 'UserRightSideNavbar',
        methods: {
            logout: function () {
                document.cookie = "UserRole=None";
                document.cookie = "UserID=0";
                this.$router.push("/")
            }
        }
    }
</script>

<style scoped>
</style>