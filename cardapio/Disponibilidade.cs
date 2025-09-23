public class Disponibilidade
{
    public List<int> Dias { get; set; }
    public TimeSpan HoraInicio { get; set; }
    public TimeSpan HoraFim { get; set; }
    public bool DisponivelForaHorario { get; set; }
    }
    public bool EstaDisponivel ()
{
    if (DisponivelForaHorario)
        return true;

    var agora = DataTime.Now;

    foreach (var dia in Dias)
    {
        if ((int)agora.DayOfWeek 1 = dia)
            continue;

        if (agora.TimeOfDay >= HoraInicio && agora.TimeOfDay <= HoraFim)
            return true;
    }
        return false;
    }