import Vue from 'vue';
import Router from 'vue-router';
import AddPage from './views/AddPage';
import MainPage from './views/MainPage';
import NewApartmentPage from './views/NewApartmentPage';
import OwnerPage from './views/OwnerPage';
import TenantPage from './views/TenantPage';


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
            component: AddPage
        },
        {
            path: '/new_apartment',
            name: 'NewApartmentPage',
            component: NewApartmentPage
        },
        {
            path: '/user/owner/:id',
            name: 'OwnerPage',
            component: OwnerPage
        },
        {
            path: '/user/tenant/:id',
            name: 'TenantPage',
            component: TenantPage
        }
    ]
})