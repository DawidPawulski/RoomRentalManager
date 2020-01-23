<template>
    <div>
        <b-navbar toggleable="lg" type="dark" variant="info">
            <b-navbar-brand href="#">RRM</b-navbar-brand>

            <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>

            <b-collapse id="nav-collapse" is-nav>
                <OwnerNavbar v-if="UserRole === 'Owner'" />
                <TenantNavbar v-else-if="UserRole === 'Tenant'" />
                <b-navbar-nav v-else>
                    <b-nav-item><router-link to="/">Marketplace</router-link></b-nav-item>
                </b-navbar-nav>

                <!-- Right aligned nav items -->
                <b-navbar-nav class="ml-auto">
                    <b-nav-form v-if="UserRole === 'None'">
                        <b-button size="sm" class="my-2 my-sm-0" type="button">Login</b-button>
                        <b-button size="sm" class="my-2 my-sm-0" type="button">Register</b-button>
                    </b-nav-form>
                    <b-nav-form v-else>
                        <b-button size="sm" class="my-2 my-sm-0" type="button">Logout</b-button>
                    </b-nav-form>


                </b-navbar-nav>
            </b-collapse>
        </b-navbar>
    </div>
</template>

<script>
    import TenantNavbar from "./TenantNavbar";
    import OwnerNavbar from "./OwnerNavbar";

    export default {
        name: 'Navbar',
        props: {
            UserRole: String
        },
        components: {
            TenantNavbar,
            OwnerNavbar
        }
    };
</script>

<style scoped>
</style>