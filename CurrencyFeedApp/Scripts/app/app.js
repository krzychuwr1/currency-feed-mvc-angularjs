var app = angular.module("currency-feed-module", []);

//Create the controller
function CurrencyFeedCtrl($scope, $http) {
    $scope.loadData = function () {
        $http.get('/api/currencydata')
            .then(function (response) {
                $scope.data = response.data;
            });
    };
}

//Register controller with module
app.controller("CurrencyFeedCtrl", CurrencyFeedCtrl); 