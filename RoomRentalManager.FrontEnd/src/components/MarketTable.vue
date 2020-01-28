<template>
    <div id="AdvertAPI">
        <table>
            <thead>
                <tr>
                    <th>Image</th>
                    <th>Title</th>
                    <th>Date</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="value in Projects" v-bind:key="value.id">
                    <td>{{ value.title }}</td>
                    <td>{{ value.description }}</td>
                    <td>{{ value.creationDate }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
    export default {
        name: 'MarketTable',
        props: {
            Projects: Object
        }
    };
</script>

<style scoped>
</style>