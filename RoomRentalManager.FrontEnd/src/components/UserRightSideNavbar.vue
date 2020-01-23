<template>
    <b-nav-form v-else>
        <b-button size="sm" class="my-2 my-sm-0" type="button">Edit Profile</b-button>
        <b-button size="sm" class="my-2 my-sm-0" type="button">Messages</b-button>
        <b-button size="sm" class="my-2 my-sm-0" type="button">Notifications</b-button>
        <b-button size="sm" class="my-2 my-sm-0" type="button">Logout</b-button>
    </b-nav-form>

</template>

<script lang="ts">
    export default {
        name: 'UserRightSideNavbar'
    }
</script>

<style scoped>
</style>