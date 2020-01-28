<template>
    <div>
        <b-navbar toggleable="lg" type="dark" variant="info">
            <b-navbar-brand href="#">RRM</b-navbar-brand>

            <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>

            <b-collapse id="nav-collapse" is-nav>
                <OwnerNavbar v-if="UserRole === 'Owner'" :UserID="UserID"/>
                <TenantNavbar v-else-if="UserRole === 'Tenant'" :UserID="UserID"/>
                <b-navbar-nav v-else>
                    <b-nav-item><router-link to="/">Marketplace</router-link></b-nav-item>
                </b-navbar-nav>

                <!-- Right aligned nav items -->
                <b-navbar-nav class="ml-auto">
                    <b-nav-form v-if="UserRole === 'None'">
                        <b-button size="sm" class="my-2 my-sm-0" type="button">Login</b-button>
                        <b-button size="sm" class="my-2 my-sm-0" v-b-modal.RegisterModal>Register</b-button>
                        <!--<b-button size="sm" class="my-2 my-sm-0" type="button">Register</b-button>-->
                    </b-nav-form>
                    <UserRightSideNavbar v-else />

                </b-navbar-nav>
            </b-collapse>
        </b-navbar>
        <RegisterModal></RegisterModal>
    </div>
</template>

<script>
    import TenantNavbar from "./TenantNavbar";
    import OwnerNavbar from "./OwnerNavbar";
    import UserRightSideNavbar from "./UserRightSideNavbar";
    import RegisterModal from "./RegisterModal";

    export default {
        name: 'Navbar',
        props: {
            UserRole: String,
            UserID: Number
        },
        components: {
            TenantNavbar,
            OwnerNavbar,
            UserRightSideNavbar,
            RegisterModal
        }
    };
</script>

<style scoped>
</style>