<template>
    <div>
        <b-card bg-variant="light">
            <b-table-simple hover striped>
                <b-thead head-variant="dark">
                    <b-tr>
                        <b-th>
                            Category
                        </b-th>
                        <b-th>
                            Value
                        </b-th>
                    </b-tr>
                </b-thead>
                <b-tbody>
                    <b-tr v-for="(value, name) in roomData" :key="value">
                        <b-td>
                            {{name}}
                        </b-td>
                        <b-td>
                            {{value}}
                        </b-td>
                    </b-tr>
                </b-tbody>
            </b-table-simple>
        </b-card>
        


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