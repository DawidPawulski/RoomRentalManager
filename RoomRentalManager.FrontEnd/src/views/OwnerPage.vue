<template>
    <div>
    <Navbar :UserRole="UserRole" :UserID="UserID" />
    <div>owner {{ $route.params.id }}</div>
        </div>
</template>

<script>
    import Navbar from '../components/Navbar.vue';
    export default {
        name: 'OwnerPage',
        components: {
            Navbar
        },
        props: {

        },
        data() {
            return {
                UserRole: RegExp("UserRole" + "=([^;]+)").exec(document.cookie)[1],
                UserID: RegExp("UserID" + "=([^;]+)").exec(document.cookie)[1]
            }
        }
    }
</script>

<style scoped>
</style>