
        var DataService = function(){
            function buildUrl(no){
                return "http://numberapi.com/"+no+"?json"
            }
            var service = {}
            service.getViaFetch = function(no){
                var promise1 = fetch(buildUrl(no));
                var promise2 = promise1.then((r)=>{
                    return r.json();
                })
                return promise2;
            }
            service.getViaXhr = function(no,fnResult){
                var xhr = new XMLHttpRequest()
                xhr.onload = (resp) => {
                    fnResult(resp);
                }
                xhr.open("GET",buildUrl(no));
                xhr.send();
            }
        }
        return service;
 