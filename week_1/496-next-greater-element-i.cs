// https://leetcode.com/problems/next-greater-element-i/description/

public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int[] nums3 = new int[nums1.Length];
        //nums1 é parte de nums2

        //verificar cada int em nums1
        //se nums2[j] == nums1[i], retornar o próximo nums2 > nums2[j]
        //se n tiver, retornar -1

        for(int i=0; i<nums1.Length; i++){
            nums3[i] = BuscaItem(nums1[i], nums2);
        }

        return nums3;
    }

    public int BuscaItem(int valor, int[] nums2){
        if (!nums2.Contains(valor)){ //se n encontrar
            return -1;
        }

        //verificar o proximo int > valor

        bool encontrou = false;
        for(int i=0;i<nums2.Length;i++){
            //buscar pelo prox > 
            if(encontrou && nums2[i] > valor){
                return nums2[i];
            }
            //encontrou o valor
            if(nums2[i]==valor){
                encontrou = true;
            }
        }

        return -1;
    }
}
