namespace Kbp.Docsvision.OfficeDocuments.DocX.Word.Generation
{
    /// <summary>
    /// Класс для генерации документа Office Word на основе шаблона.
    /// </summary>
    /// <remarks>
    /// В качестве шаблона выступает документ Office Word, содержащий "заглушки",
    /// <br/>которые будут заменены переданными значениями, а также строки таблиц,
    /// <br/>основанными на переданном массиве значений.
    /// </remarks>
    public static class Generator
    {
        /// <summary>
        /// Гененирация документа Office Word на основе документа-шаблоне и данных для замены.
        /// </summary>
        /// <param name="templateFilePath">Путь к документу-шаблону.</param>
        /// <param name="templateReplacementData">Данные для замены в шаблоне.</param>
        /// <param name="outputFilePath">Путь к сгенерированному документу.</param>
        public static void GenerateDocumentFromTemplate(
            string templateFilePath,
            TemplateReplacementData templateReplacementData,
            string outputFilePath)
        {

        }
    }
}
