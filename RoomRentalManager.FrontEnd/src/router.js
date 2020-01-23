import Vue from 'vue';
import Router from 'vue-router';
import AddPage from './views/AddPage';
import MainPage from './views/MainPage';
import NewApartmentPage from './views/NewApartmentPage';
import OwnerPage from './views/OwnerPage';
import TenantPage from './views/TenantPage';
import AllTenantsPage from './views/AllTenantsPage';


Vue.use(Router);

export default new Router({
    mode: 'history',
    routes: [
        {
            path: '/',
            name: 'MainPage',
            component: MainPage
        },
        {
            path: '/advert/:id',
            name: 'AddPage',
            component: AddPage,
            props: true 
        },
        {
            path: '/new_apartment',
            name: 'NewApartmentPage',
            component: NewApartmentPage
        },
        {
            path: '/user/owner/:id',
            name: 'OwnerPage',
            component: OwnerPage,
            props: true 
        },
        {
            path: '/user/tenant/:id',
            name: 'TenantPage',
            component: TenantPage,
            props: true 
        },
        {
            path: '/all_tenants',
            name: 'AllTenantsPage',
            component: AllTenantsPage
        },

    ]
})