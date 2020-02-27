<template>
    <div>
        <Navbar :UserRole="UserRole" :UserID="UserID" />
        <div>
            <b-row align-h="center">
                <b-col cols="10">

                    <div>
                        <b-form @submit="onSubmit" id="apartment-form">
                            <br />
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
                            <br />
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
                                    <b-form-checkbox-group switches>
                                        <b-form-checkbox id="smoking"
                                                         v-model="form.smokingAllowed">Smoking Allowed</b-form-checkbox>
                                    </b-form-checkbox-group>
                                    <b-form-checkbox-group switches>
                                        <b-form-checkbox id="pets"
                                                         v-model="form.petsAllowed">Pets Allowed</b-form-checkbox>
                                    </b-form-checkbox-group>


                                    <b-form-group v-if="numberOfRooms <= 1"
                                                  id="room-input"
                                                  :key="numberOfRooms">
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
                                        <b-tab v-for="i in parseInt(numberOfRooms)" :key="i" :title="i.toString()">
                                            <b-form-group id="room-input">
                                                <b-form-checkbox-group id="room-input-1"
                                                                       switches
                                                                       stacked>
                                                    <b-form-checkbox id="furnished"
                                                                     v-model="room.furnished">Furnished</b-form-checkbox>

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
                                                <b-form-group id="room-input-4"
                                                              label="Room area:"
                                                              label-for="roomArea">
                                                    <b-form-input id="roomArea"
                                                                  v-model="room.area"
                                                                  type="number"
                                                                  required
                                                                  placeholder="Bank Account Number"></b-form-input>
                                                </b-form-group>
                                            </b-form-group>

                                            <b-button typeof="button" :key="i" id="'save' + i.toString()" v-on:click="saveRoom()">Save</b-button>
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
                </b-col>
            </b-row>
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
                    petsAllowed: '',
                    roomsList: []
                },
                room: {
                    furnished: '',
                    monthlyAmount: '',
                    bankAccount: '',
                    area: ''
                }
            }
        },
        methods: {
            onSubmit(evt) {
                evt.preventDefault()
                if (this.form.roomsList.length == 0) {
                    this.room.area = this.form.area
                    this.saveRoom()
                }
                // error coming up Error in v-on handler: "TypeError: Cannot read property 'then' of undefined"
                // ask Piotr or Maciek for help with that
                this.sendApartment().then(response => {
                    this.form.roomsList.foreach((room) => {
                        this.sendRoom(room, response.data.ApartmentId)
                    })
                })

                alert(JSON.stringify(this.form))
            },
            // change it to recognize rooms later and update after another save or add edit button
            saveRoom() {
                let room = {
                    furnished: this.room.furnished,
                    monthlyAmount: this.room.monthlyAmount,
                    bankAccount: this.room.bankAccount,
                    area: this.room.area
                }

                this.form.roomsList.push(room)

                if (this.form.roomsList.length > this.form.rooms) {
                    this.form.roomsList.pop();
                }
            },
            /* eslint-disable */
            sendApartment() {
                let date = new Date(this.form.year, 1, 1);
                let smoking = false;
                let pets = false;
                if (this.form.smokingAllowed.length >0 && this.form.smokingAllowed[0] == true) {
                    smoking = true;
                }
                if (this.form.petsAllowed.length > 0 && this.form.petsAllowed[0] == true) {
                    pets = true;
                }
                const axios = require('axios');
                let url = "https://localhost:44311/api/Apartments"
                axios.post(url, {
                    "UserID": parseInt(this.UserID),
                    "NumberOfRooms": parseInt(this.form.rooms),
                    "SmokingAllowed": smoking,
                    "PetsAllowed": pets,
                    "YearOfRenovation": date,
                    "Floor": parseInt(this.form.floor),
                    "City": this.form.city,
                    "Street": this.form.street,
                    "BuildingNumber": parseInt(this.form.buildingNumber),
                    "ApartmentNumber": parseInt(this.form.apartmentNumber),
                    "PostalCode": this.form.postalCode,
                    "Area": parseInt(this.form.area)
                }).then((response) => {
                    console.log(response)
                    return response
                })
            },
            /* eslint-disable */
            sendRoom(object, apartmentId) {
                let furnished = false;
                if (object.furnished.length > 0 && object.furnished[0] == true) {
                    furnished = true;
                }
                const axios = require('axios');
                let url = "https://localhost:44311/api/Rooms";
                axios.post(url, {
                    "ApartmentId": apartmentId,
                    "Area": object.area,
                    "Furnished": furnished,
                    "MonthlyAmount": object.monthlyAmount,
                    "BankAccountNumber": object.bankAccount
                }).then((response) => {
                    console.log(response)
                    return response
                })
            }



        },
        computed: {
            numberOfRooms: function () {

                return this.form.rooms;
            }
        }
    }
</script>

<style scoped>
</style>