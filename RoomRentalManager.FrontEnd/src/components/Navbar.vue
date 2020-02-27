<template>
    <div>
        <b-navbar toggleable="lg" type="dark" variant="info">
            <b-navbar-brand href="#">RRM</b-navbar-brand>

            <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>

            <b-collapse id="nav-collapse" is-nav>
                <OwnerNavbar v-if="UserRole === 'Owner'" :UserID="UserID" />
                <TenantNavbar v-else-if="UserRole === 'Tenant'" :UserID="UserID" />
                <b-navbar-nav v-else>
                    <b-button size="sm" class="my-2 my-sm-0" type="button" variant="dark">
                        <b-nav-item><router-link to="/" style="color:white">Marketplace</router-link></b-nav-item>
                    </b-button>
                </b-navbar-nav>

                <!-- Right aligned nav items -->
                <b-navbar-nav class="ml-auto">
                    <b-nav-form v-if="UserRole === 'None'">
                        <b-button-group>
                            <b-button size="sm" class="my-2 my-sm-0" v-b-modal.LoginModal variant="dark">Login</b-button>
                            <p> </p>
                            <b-button size="sm" class="my-2 my-sm-0" v-b-modal.RegisterModal variant="dark">Register</b-button>
                        </b-button-group>
                    </b-nav-form>
                    <UserRightSideNavbar v-else />

                </b-navbar-nav>
            </b-collapse>
        </b-navbar>
        <RegisterModal></RegisterModal>
        <LoginModal></LoginModal>
    </div>
</template>

<script>
    import TenantNavbar from "./TenantNavbar";
    import OwnerNavbar from "./OwnerNavbar";
    import UserRightSideNavbar from "./UserRightSideNavbar";
    import RegisterModal from "./RegisterModal";
    import LoginModal from "./LoginModal"

    export default {
        name: 'Navbar',
        props: {
            UserRole: String,
            UserID: String
        },
        components: {
            TenantNavbar,
            OwnerNavbar,
            UserRightSideNavbar,
            RegisterModal,
            LoginModal
        }
    };
</script>

<style scoped>
</style>