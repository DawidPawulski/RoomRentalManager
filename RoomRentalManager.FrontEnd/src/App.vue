<template>
    <div id="app">
        <router-view>
        </router-view>
    </div>
</template>

<script>

    export default {
        name: 'app',
        components: {
        },
        mounted: function() {
            document.cookie = "UserRole=None",
            document.cookie = "UserID=0"
        }
    };
</script>

<style>
</style>

