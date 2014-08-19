var map;

AmCharts.ready(function () {

    map = new AmCharts.AmMap();
    map.pathToImages = "http://www.amcharts.com/lib/3/images/";
    map.panEventsEnabled = true;
    map.backgroundColor = "#282828";
    map.backgroundAlpha = 1;

    map.zoomControl.panControlEnabled = true;
    map.zoomControl.zoomControlEnabled = true;
    map.zoomControl.buttonFillColor = "#282828";

    map.mouseWheelZoomEnabled = true;
    

    var dataProvider = {
        map: "worldLow",
        getAreasFromMap: true
    };

    map.dataProvider = dataProvider;

    map.areasSettings = {
        autoZoom: false,
        color: "#CDCDCD",
        colorSolid: "#5EB7DE",
        selectedColor: "#5EB7DE",
        outlineColor: "#666666",
        rollOverColor: "#88CAE7",
        rollOverOutlineColor: "#FFFFFF",
        selectable: true
    };

    map.addListener('clickMapObject', function (event) {
                  
        alert(event.mapObject.title);

    });

    function handleGoHome() {
        map.dataProvider = continentsDataProvider;
        map.validateNow();
    }



    map.addListener("homeButtonClicked", handleGoHome);
    map.write("mapdiv");
});
