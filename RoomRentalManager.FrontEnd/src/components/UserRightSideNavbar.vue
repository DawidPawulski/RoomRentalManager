<template>
    <b-nav-form>
        <b-button size="sm" class="my-2 my-sm-0" type="button">Edit Profile</b-button>
        <b-button size="sm" class="my-2 my-sm-0" type="button">Messages</b-button>
        <b-button size="sm" class="my-2 my-sm-0" type="button">Notifications</b-button>
        <b-button size="sm" class="my-2 my-sm-0" type="button" v-on:click="logout">Logout</b-button>
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