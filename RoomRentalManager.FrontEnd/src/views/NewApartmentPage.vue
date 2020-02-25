<template>
    <div>
        <Navbar :UserRole="UserRole" :UserID="UserID" />
        <div>
            newapartment
            <div>
                <b-form @submit="onSubmit" @reset="onReset" v-if="show">
                    <b-card bg-variant="light">
                        <b-form-group label="Apartment Adress Details"></b-form-group>

                        <b-form-group id="adress-input-1"
                                      label="City:"
                                      label-for="city">
                            <b-form-input id="city"
                                          v-model="form.city"
                                          type="text"
                                          required
                                          placeholder="City"></b-form-input>
                        </b-form-group>

                        <b-form-group id="adress-input-2"
                                      label="Street:"
                                      label-for="street">
                            <b-form-input id="city"
                                          v-model="form.street"
                                          type="text"
                                          required
                                          placeholder="Street"></b-form-input>
                        </b-form-group>

                        <b-form-group id="adress-input-3"
                                      label="Building Number:"
                                      label-for="building-number">
                            <b-form-input id="building-number"
                                          v-model="form.buildingNumber"
                                          type="number"
                                          required
                                          placeholder="Building Number"></b-form-input>
                        </b-form-group>

                        <b-form-group id="adress-input-4"
                                      label="Apartment Number:"
                                      label-for="apartment-number">
                            <b-form-input id="apartment-number"
                                          v-model="form.apartmentNumber"
                                          type="number"
                                          required
                                          placeholder="Apartment Number"></b-form-input>
                        </b-form-group>

                        <b-form-group id="adress-input-5"
                                      label="Postal Code:"
                                      label-for="postal-code">
                            <b-form-input id="postal-code"
                                          v-model="form.postalCode"
                                          type="text"
                                          required
                                          pattern="[0-9]{2}\-[0-9]{3}"
                                          placeholder="Apartment Number"></b-form-input>
                        </b-form-group>

                        <b-form-group id="adress-input-6"
                                      label="Floor:"
                                      label-for="floor">
                            <b-form-input id="floor"
                                          v-model="form.floor"
                                          type="number"
                                          required
                                          placeholder="Floor Number"></b-form-input>
                        </b-form-group>

                    </b-card>

                    <b-card bg-variant="light">
                        <b-form-group label="Apartment Details"></b-form-group>

                        <b-form-group id="details-input-1"
                                      label="Area(in sq meters):"
                                      label-for="area">
                            <b-form-input id="area"
                                          v-model="form.area"
                                          type="number"
                                          required
                                          placeholder="area in sq meters"></b-form-input>
                        </b-form-group>

                        <b-form-group id="details-input-2"
                                      label="Year of last Renovation:"
                                      label-for="year">
                            <b-form-input id="year"
                                          v-model="form.year"
                                          type="number"
                                          pattern="[0-9]{4}"
                                          required
                                          placeholder="year of renovation"></b-form-input>
                        </b-form-group>

                        <b-form-group id="details-input-3"
                                      label="Number of rooms:"
                                      label-for="rooms">
                            <b-form-input id="rooms"
                                          v-model="form.rooms"
                                          type="number"
                                          required
                                          placeholder="Number Of Rooms"></b-form-input>
                        </b-form-group>

                        <b-form-group id="details-input-4">
                            <b-form-checkbox-group switches
                                                   stacked>
                                <b-form-checkbox id="smoking"
                                                 v-model="form.smokingAllowed">Smoking Allowed</b-form-checkbox>
                                <b-form-checkbox id="pets"
                                                 v-model="form.petsAllowed">Pets Allowed</b-form-checkbox>
                            </b-form-checkbox-group>


                            <b-form-group v-if="form.rooms <= 1"
                                          id="room-input">
                                <b-form-checkbox-group id="room-input-1"
                                                       switches
                                                       stacked>
                                    <b-form-checkbox id="furnished"
                                                     v-model="room.furnished"
                                                     value="furnished">Furnished</b-form-checkbox>

                                </b-form-checkbox-group>

                                <b-form-group id="room-input-2"
                                              label="Monthly Amount:"
                                              label-for="monthlyAmount">
                                    <b-form-input id="monthlyAmount"
                                                  v-model="room.monthlyAmount"
                                                  type="number"
                                                  required
                                                  placeholder="Monthly Amount"></b-form-input>
                                </b-form-group>

                                <b-form-group id="room-input-3"
                                              label="Bank Account Number:"
                                              label-for="bankAccount">
                                    <b-form-input id="bankAccount"
                                                  v-model="room.bankAccount"
                                                  type="text"
                                                  pattern="[0-9]{26}"
                                                  required
                                                  placeholder="Bank Account Number"></b-form-input>
                                </b-form-group>


                            </b-form-group>

                            <b-tabs v-else content-class="mt-3">
                                <b-tab v-for="i in parseInt(this.form.rooms)" :key="i" title="Room {i+1}">
                                    <b-form-group id="room{i + 1}-input">
                                        <b-form-checkbox-group id="room{i + 1}-input-1"
                                                               switches
                                                               stacked>
                                            <b-form-checkbox id="furnished"
                                                             v-model="room.furnished"
                                                             value="furnished">Furnished</b-form-checkbox>

                                        </b-form-checkbox-group>

                                        <b-form-group id="room{i + 1}-input-2"
                                                      label="Monthly Amount:"
                                                      label-for="monthlyAmount">
                                            <b-form-input id="monthlyAmount"
                                                          v-model="room.monthlyAmount"
                                                          type="number"
                                                          required
                                                          placeholder="Monthly Amount"></b-form-input>
                                        </b-form-group>

                                        <b-form-group id="room{i + 1}-input-3"
                                                      label="Bank Account Number:"
                                                      label-for="bankAccount">
                                            <b-form-input id="bankAccount"
                                                          v-model="room.bankAccount"
                                                          type="text"
                                                          pattern="[0-9]{26}"
                                                          required
                                                          placeholder="Bank Account Number"></b-form-input>
                                        </b-form-group>
                                    </b-form-group>
                                </b-tab>

                            </b-tabs>

                        </b-form-group>
                    </b-card>




                    <b-button type="submit" variant="primary">Submit</b-button>
                </b-form>
                <b-card class="mt-3" header="Form Data Result">
                    <pre class="m-0">{{ form }}</pre>
                </b-card>
            </div>

        </div>
    </div>
</template>

<script>
    import Navbar from '../components/Navbar.vue';
    export default {
        name: 'NewApartmentPage',
        components: {
            Navbar
        },
        props: {

        },
        data() {
            return {
                UserRole: RegExp("UserRole" + "=([^;]+)").exec(document.cookie)[1],
                UserID: RegExp("UserID" + "=([^;]+)").exec(document.cookie)[1],
                form: {
                    city: '',
                    street: '',
                    buildingNumber: '',
                    apartmentNumber: '',
                    postalCode: '',
                    floor: '',
                    area: '',
                    year: '',
                    rooms: '',
                    smokingAllowed: '',
                    petsAllowed: ''
                },
                // figure out how to do number of rooms programatically
                room: {
                    furnished: '',
                    monthlyAmount: '',
                    bankAccount: '',
                    area: ''
                },
                show: true
            }
        },
        methods: {
            onSubmit(evt) {
                evt.preventDefault()
                alert(JSON.stringify(this.form))
            }


        }
    }
</script>

<style scoped>
</style>