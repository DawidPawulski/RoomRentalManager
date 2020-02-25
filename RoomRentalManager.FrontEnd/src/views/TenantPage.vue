<template>
    <div>
        <Navbar :UserRole="UserRole" :UserID="UserID" />
        <div>tenant {{ $route.params.id }}</div>
    </div>
</template>

<script>
    import Navbar from '../components/Navbar.vue';
    export default {
        name: 'TenantPage',
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