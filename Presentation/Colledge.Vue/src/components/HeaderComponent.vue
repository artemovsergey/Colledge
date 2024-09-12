<template>

    <div>
        <h1> Header </h1>        
    </div>

</template>

<script setup lang="ts">

    import {ref, onMounted} from 'vue'
    const count = ref(0)

    onMounted(() => {
        console.log(`The initial count is ${count.value}.`)
    })

</script> 


<style scoped>
div{
    background-color: green;
}

</style>