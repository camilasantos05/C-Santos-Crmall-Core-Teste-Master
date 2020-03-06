import Vue from 'vue';

Vue.directive('sexo-enum', {

    bind(el, binding, vnode) {

        if(el.innerHTML.trim() === "0")  {
            el.innerHTML = "Feminino"
            return;
        }
		
		if(el.innerHTML.trim() === "1")  {
            el.innerHTML = "Masculino"
            return;
        }
		
		 if(el.innerHTML.trim() === "2")  {
            el.innerHTML = "NaoBinario"
            return;
        }

        if(el.innerHTML.trim() === "3")  {
            el.innerHTML = "Outros"
            return;
        }
    }
    
});