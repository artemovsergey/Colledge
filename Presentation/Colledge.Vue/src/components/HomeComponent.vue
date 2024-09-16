<template>

    <div class="container">
        <h1> Hello World</h1>
        
        <button class="btn btn-primary" @click="count++">
            Значение: {{ count }}
        </button>
        
    </div>

</template>

<script setup lang="ts">

    import {ref, onMounted} from 'vue'
    const count = ref(0)

    // lifecycle hooks
    onMounted(() => {
        console.log(`The initial count is ${count.value}.`)
    })

</script> 