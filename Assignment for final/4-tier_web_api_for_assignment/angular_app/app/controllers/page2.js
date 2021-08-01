app.controller("demo2",function($scope,$http,ajax){
    $scope.lname = "Toufiqul";
    ajax.get("https://localhost:44368/api/Person",success,error);
    function success(response){
      $scope.myWelcome=response.data;
    }
    function error(error){
    }
    var data = {};
    data.Id=1;
    data.Name="Student 1";
    data.Dob = "445";
    ajax.post("https://localhost:44368/api/Person",data,function(){
    },function(){

    });
});
