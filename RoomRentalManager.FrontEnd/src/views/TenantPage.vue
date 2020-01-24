<template>
    <div>tenant {{ $route.params.id }}</div>
</template>

<script>
    export default {
        name: 'TenantPage',
        props: {
            UserID: Number
        }
    }
</script>

<style scoped>
</style>