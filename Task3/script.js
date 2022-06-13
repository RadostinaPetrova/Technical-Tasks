function solve(inputSelector) {
        let selector = document.querySelector(inputSelector);
        let array = [];
        
        getAllDescendants(selector);
        
        function getAllDescendants(selector) {

          exctractAllChildrenFromNode(selector);

          function exctractAllChildrenFromNode(node) {             
            for (let i = 0; i < node.childNodes.length; i++) {
                let child = node.childNodes[i];

                if (child.nodeType === document.ELEMENT_NODE) {
                  exctractAllChildrenFromNode(child);
                }
            }
          
           array.push(node.nodeName);
        }
      }               
      console.log(array);
      };
