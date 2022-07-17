import {createRouter, createWebHistory} from 'vue-router';

const routes = [
    {
        name: 'Home',
        path: '/',
        component: () => import('@/views/Home/Home.vue'),
    },
    {
        name: 'About',
        path: '/about',
        component: () => import('@/views/About/About.vue'),
    },
    {
        name: 'Aliment',
        path: '/Aliment/:name',
        props: true,
        component: () => import('@/views/Product/Product.vue'),
    }
];

const router = createRouter({
    history: createWebHistory(),
    routes,
})

export default router;
