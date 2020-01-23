<template>
    <table>
        <thead>
            <tr>
                <th>Image</th>
                <th>Title</th>
                <th>Date</th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="advert in AdvertList" v-bind:key="advert.date">
                <td>{{ advert.image }}</td>
                <td>{{ advert.title }}</td>
                <td>{{ advert.date }}</td>
            </tr>
        </tbody>
    </table>
</template>

<script>
    export default {
        name: 'MarketTable',
        props: {
            AdvertList: Array
        }
    };
</script>

<style scoped>
</style>