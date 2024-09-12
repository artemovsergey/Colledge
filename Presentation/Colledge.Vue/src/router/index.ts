import { createRouter, createWebHistory } from 'vue-router'
//@ts-ignore
import HomeComponent from '@/components/HomeComponent.vue'


const router = createRouter({
  //@ts-ignore
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: HomeComponent
    },
    {
      path: '/about',
      name: 'about',
      // route level code-splitting
      // this generates a separate chunk (About.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      //@ts-ignore
      component: () => import('@/components/HomeComponent.vue')
    }
  ]
})

export default router
