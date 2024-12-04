function getElementPosition(elementId) {
    var element = document.getElementById(elementId);
    if (element) {
        var rect = element.getBoundingClientRect();
        console.log("Event Target:", rect.top, rect.left);
        return {
            top: rect.top + window.scrollY,
            left: rect.left + window.scrollX
        };
    }
    return null;
}
function changeSVGColor(svgElementId, color) {
    // Получаем элемент SVG по его ID
    var svgElement = document.getElementById(svgElementId);
    
    // Проверяем, существует ли элемент
    if (svgElement) {
        // Изменяем цвет заполнения (fill)
        svgElement.style.fill = color;
    } else {
        console.error("SVG элемент не найден с ID: " + svgElementId);
    }
}

function getElementId(event) {
    console.log("Event Target:", event.target);
    return event.target.id;
}