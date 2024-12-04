public class FilterData
{
    public string Query { get; set; } // Слово-фильтр
    public int FilterChoice { get; set; } // Тип фильтрации (0 - равенство, 1 - вхождение)
    public bool IsActive { get; set; } // Активен ли фильтр
}