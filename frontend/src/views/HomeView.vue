<template>
  <div>
    <h1>Halak</h1>
    <p>Fish are aquatic animals; they are identified as vertebrates that have gills and fins instead of limbs. 
The majority of fish have streamlined and generalized bodies.
Another fact is that fish do not chew their food because it would obstruct the passage of water through their gills, and if they did, they would suffocate.
One of the characteristics of fish is that they lack eyelids (except for sharks) which makes them incapable of blinking.
Fish lack vocal cords and communicate with one another by making low-pitched sounds. Groan, croak, boom, hiss, whistle, creak, shriek, and wail are some of the sounds they make. </p>
  </div>
</template>

<script setup>
import Counter from "@/components/Counter.vue";
import { useCounterStore } from "@/stores/counter";
const storeCounter = useCounterStore();
</script>

<style>

</style>
