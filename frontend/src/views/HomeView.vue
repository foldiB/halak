<template>
  <div>
    <h1>Halak</h1>
    <p>Fish are aquatic animals; they are identified as vertebrates that have gills and fins instead of limbs. 
The majority of fish have streamlined and generalized bodies.
Another fact is that fish do not chew their food because it would obstruct the passage of water through their gills, and if they did, they would suffocate.
One of the characteristics of fish is that they lack eyelids (except for sharks) which makes them incapable of blinking.
Fish lack vocal cords and communicate with one another by making low-pitched sounds. Groan, croak, boom, hiss, whistle, creak, shriek, and wail are some of the sounds they make. </p>
<div class="card" style="width: 18rem;">
  <img src="pics/1.jpg"  class="card-img-top" alt="...">
  <div class="card-body">
    <h5  class="card-title">{{}}</h5>
    <p id="lll" class="card-text">In the wild, the yellow boxfish (known scientifically as Ostracion argus or tuberculatus) lives in coral and rocky reefs in the Indo-Pacific ocean. It is a stunning, if quirky, looking sea creature. Though it may look funny, you wouldn’t want to laugh and upset it if you were a neighbor on the reef! No, it doesn’t have razor-sharp teeth, but, trust me, you don’t want to be besties with a yellow boxfish!</p>
    <a href="#" class="btn btn-primary">o</a>
  </div>
</div>
  </div>
</template>

<script setup>
import Counter from "@/components/Counter.vue";
import { useCounterStore } from "@/stores/counter";
const storeCounter = useCounterStore();
</script>

<style>
#lll{
  color: black;
}

</style>
