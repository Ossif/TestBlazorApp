function getElementPosition(elementId) {
    var element = document.getElementById(elementId);
    if (element) {
        var rect = element.getBoundingClientRect();
        return {
            top: rect.bottom + window.scrollY + 5, // Позиция ниже элемента
            left: rect.left + window.scrollX // Позиция по горизонтали
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