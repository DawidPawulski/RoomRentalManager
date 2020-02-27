<template>
    <div>
        <ul>
            <li v-for="data in roomData" :key="data.id">
                {{data}}
            </li>
        </ul>
    </div>
</template>

<script>
    export default {
        name: "DataBox",
        props: {
            roomData: Object,
        }
    }
</script>

<style scoped>
</style>