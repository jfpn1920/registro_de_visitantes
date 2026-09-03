Imports System
Module registro_de_visitantes
    Sub Main(args As String())
        Dim ids(19) As Integer
        Dim nombres(19) As String
        Dim documentos(19) As String
        Dim telefonos(19) As String
        Dim personasVisitadas(19) As String
        Dim areas(19) As String
        Dim motivos(19) As String
        Dim horasEntrada(19) As String
        Dim horasSalida(19) As String
        Dim estados(19) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '-------------------------------------------'
        '--|menu_principal_registro_de_visitantes|--'
        '-------------------------------------------'
        Do
            Console.WriteLine("menu principal registro de visitantes")
            Console.WriteLine("1) Registrar visitante")
            Console.WriteLine("2) Editar visitante")
            Console.WriteLine("3) Listar visitantes")
            Console.WriteLine("4) Buscar visitante")
            Console.WriteLine("5) Eliminar visitante")
            Console.WriteLine("6) Controlar visitas")
            Console.WriteLine("7) Mostrar resumen")
            Console.WriteLine("8) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '-------------------------'
                '--|registrar_visitante|--'
                '-------------------------'
                Case 1
                    If cantidad >= 20 Then
                        Console.WriteLine("No se pueden registrar mas visitantes.")
                    Else
                        Console.Write("Ingrese el nombre del visitante: ")
                        Dim nuevoNombre As String = Console.ReadLine()
                        If nuevoNombre = "" Then
                            Console.WriteLine("El nombre no puede estar vacio.")
                        Else
                            Console.Write("Ingrese el documento: ")
                            Dim nuevoDocumento As String = Console.ReadLine()
                            If nuevoDocumento = "" Then
                                Console.WriteLine("El documento no puede estar vacio.")
                            Else
                                Dim documentoExiste As Boolean = False
                                For i As Integer = 0 To cantidad - 1
                                    If documentos(i).ToLower() = nuevoDocumento.ToLower() Then
                                        documentoExiste = True
                                    End If
                                Next
                                If documentoExiste Then
                                    Console.WriteLine("El documento ya se encuentra registrado.")
                                Else
                                    Console.Write("Ingrese el telefono: ")
                                    Dim nuevoTelefono As String = Console.ReadLine()
                                    If nuevoTelefono = "" Then
                                        Console.WriteLine("El telefono no puede estar vacio.")
                                    Else
                                        Console.Write("Ingrese la persona que visita: ")
                                        Dim nuevaPersonaVisitada As String = Console.ReadLine()
                                        If nuevaPersonaVisitada = "" Then
                                            Console.WriteLine("La persona visitada no puede estar vacia.")
                                        Else
                                            Console.Write("Ingrese el area: ")
                                            Dim nuevaArea As String = Console.ReadLine()
                                            If nuevaArea = "" Then
                                                Console.WriteLine("El area no puede estar vacia.")
                                            Else
                                                Console.Write("Ingrese el motivo de la visita: ")
                                                Dim nuevoMotivo As String = Console.ReadLine()
                                                If nuevoMotivo = "" Then
                                                    Console.WriteLine("El motivo no puede estar vacio.")
                                                Else
                                                    Console.Write("Ingrese la hora de entrada: ")
                                                    Dim nuevaHoraEntrada As String = Console.ReadLine()
                                                    If nuevaHoraEntrada = "" Then
                                                        Console.WriteLine("La hora de entrada no puede estar vacia.")
                                                    Else
                                                        ids(cantidad) = cantidad + 1
                                                        nombres(cantidad) = nuevoNombre
                                                        documentos(cantidad) = nuevoDocumento
                                                        telefonos(cantidad) = nuevoTelefono
                                                        personasVisitadas(cantidad) = nuevaPersonaVisitada
                                                        areas(cantidad) = nuevaArea
                                                        motivos(cantidad) = nuevoMotivo
                                                        horasEntrada(cantidad) = nuevaHoraEntrada
                                                        horasSalida(cantidad) = ""
                                                        estados(cantidad) = "En visita"
                                                        cantidad += 1
                                                        Console.WriteLine("Visitante registrado correctamente.")
                                                        Console.WriteLine("ID: " & ids(cantidad - 1) & " | Nombre: " & nombres(cantidad - 1) & " | Documento: " & documentos(cantidad - 1) & " | Telefono: " & telefonos(cantidad - 1) & " | Persona visitada: " & personasVisitadas(cantidad - 1) & " | Area: " & areas(cantidad - 1) & " | Motivo: " & motivos(cantidad - 1) & " | Entrada: " & horasEntrada(cantidad - 1) & " | Salida: " & horasSalida(cantidad - 1) & " | Estado: " & estados(cantidad - 1))
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                '----------------------'
                '--|editar_visitante|--'
                '----------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No hay visitantes registrados.")
                    Else
                        Console.Write("Ingrese el ID del visitante: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        Dim encontrado As Boolean = False
                        For i As Integer = 0 To cantidad - 1
                            If ids(i) = idEditar Then
                                encontrado = True
                                Console.Write("Ingrese el nuevo nombre: ")
                                Dim nuevoNombre As String = Console.ReadLine()
                                If nuevoNombre <> "" Then
                                    nombres(i) = nuevoNombre
                                End If
                                Console.Write("Ingrese el nuevo documento: ")
                                Dim nuevoDocumento As String = Console.ReadLine()
                                If nuevoDocumento <> "" Then
                                    Dim documentoExiste As Boolean = False
                                    For j As Integer = 0 To cantidad - 1
                                        If j <> i And documentos(j).ToLower() = nuevoDocumento.ToLower() Then
                                            documentoExiste = True
                                        End If
                                    Next
                                    If documentoExiste Then
                                        Console.WriteLine("El documento ya se encuentra registrado por otro visitante.")
                                    Else
                                        documentos(i) = nuevoDocumento
                                    End If
                                End If
                                Console.Write("Ingrese el nuevo telefono: ")
                                Dim nuevoTelefono As String = Console.ReadLine()
                                If nuevoTelefono <> "" Then
                                    telefonos(i) = nuevoTelefono
                                End If
                                Console.Write("Ingrese la nueva persona visitada: ")
                                Dim nuevaPersonaVisitada As String = Console.ReadLine()
                                If nuevaPersonaVisitada <> "" Then
                                    personasVisitadas(i) = nuevaPersonaVisitada
                                End If
                                Console.Write("Ingrese la nueva area: ")
                                Dim nuevaArea As String = Console.ReadLine()
                                If nuevaArea <> "" Then
                                    areas(i) = nuevaArea
                                End If
                                Console.Write("Ingrese el nuevo motivo: ")
                                Dim nuevoMotivo As String = Console.ReadLine()
                                If nuevoMotivo <> "" Then
                                    motivos(i) = nuevoMotivo
                                End If
                                Console.Write("Ingrese la nueva hora de entrada: ")
                                Dim nuevaHoraEntrada As String = Console.ReadLine()
                                If nuevaHoraEntrada <> "" Then
                                    horasEntrada(i) = nuevaHoraEntrada
                                End If
                                Console.Write("Ingrese la nueva hora de salida: ")
                                Dim nuevaHoraSalida As String = Console.ReadLine()
                                If nuevaHoraSalida <> "" Then
                                    horasSalida(i) = nuevaHoraSalida
                                End If
                                Console.WriteLine("1) En visita")
                                Console.WriteLine("2) Finalizada")
                                Console.WriteLine("3) Cancelada")
                                Console.Write("Seleccione el nuevo estado: ")
                                Dim opcionEstado As Integer = Convert.ToInt32(Console.ReadLine())
                                Select Case opcionEstado
                                    '---------------'
                                    '--|en_visita|--'
                                    '---------------'
                                    Case 1
                                        estados(i) = "En visita"
                                    '----------------'
                                    '--|finalizada|--'
                                    '----------------'
                                    Case 2
                                        estados(i) = "Finalizada"
                                    '---------------'
                                    '--|cancelada|--'
                                    '---------------'
                                    Case 3
                                        estados(i) = "Cancelada"
                                    Case Else
                                        Console.WriteLine("Opcion de estado no valida.")
                                End Select
                                Console.WriteLine("Visitante actualizado correctamente.")
                                Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Telefono: " & telefonos(i) & " | Persona visitada: " & personasVisitadas(i) & " | Area: " & areas(i) & " | Motivo: " & motivos(i) & " | Entrada: " & horasEntrada(i) & " | Salida: " & horasSalida(i) & " | Estado: " & estados(i))
                            End If
                        Next
                        If encontrado = False Then
                            Console.WriteLine("No se encontro un visitante con ese ID.")
                        End If
                    End If
                '-----------------------'
                '--|listar_visitantes|--'
                '-----------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No hay visitantes registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Telefono: " & telefonos(i) & " | Persona visitada: " & personasVisitadas(i) & " | Area: " & areas(i) & " | Motivo: " & motivos(i) & " | Entrada: " & horasEntrada(i) & " | Salida: " & horasSalida(i) & " | Estado: " & estados(i))
                        Next
                    End If
                '----------------------'
                '--|buscar_visitante|--'
                '----------------------'
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No hay visitantes registrados.")
                    Else
                        Console.WriteLine("1) Buscar por ID")
                        Console.WriteLine("2) Buscar por nombre")
                        Console.WriteLine("3) Buscar por documento")
                        Console.WriteLine("4) Buscar por persona visitada")
                        Console.WriteLine("5) Buscar por area")
                        Console.WriteLine("6) Buscar por estado")
                        Console.WriteLine("7) Mostrar todos")
                        Console.Write("Seleccione una opcion: ")
                        Dim opcionBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                        Select Case opcionBuscar
                            '-------------------'
                            '--|buscar_por_id|--'
                            '-------------------'
                            Case 1
                                Console.Write("Ingrese el ID: ")
                                Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                                Dim encontrado As Boolean = False
                                For i As Integer = 0 To cantidad - 1
                                    If ids(i) = idBuscar Then
                                        encontrado = True
                                        Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Telefono: " & telefonos(i) & " | Persona visitada: " & personasVisitadas(i) & " | Area: " & areas(i) & " | Motivo: " & motivos(i) & " | Entrada: " & horasEntrada(i) & " | Salida: " & horasSalida(i) & " | Estado: " & estados(i))
                                    End If
                                Next
                                If encontrado = False Then
                                    Console.WriteLine("No se encontro el visitante.")
                                End If
                            '-----------------------'
                            '--|buscar_por_nombre|--'
                            '-----------------------'
                            Case 2
                                Console.Write("Ingrese el nombre: ")
                                Dim nombreBuscar As String = Console.ReadLine()
                                Dim encontrado As Boolean = False
                                For i As Integer = 0 To cantidad - 1
                                    If nombres(i).ToLower().Contains(nombreBuscar.ToLower()) Then
                                        encontrado = True
                                        Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Telefono: " & telefonos(i) & " | Persona visitada: " & personasVisitadas(i) & " | Area: " & areas(i) & " | Motivo: " & motivos(i) & " | Entrada: " & horasEntrada(i) & " | Salida: " & horasSalida(i) & " | Estado: " & estados(i))
                                    End If
                                Next
                                If encontrado = False Then
                                    Console.WriteLine("No se encontraron visitantes.")
                                End If
                            '--------------------------'
                            '--|buscar_por_documento|--'
                            '--------------------------'
                            Case 3
                                Console.Write("Ingrese el documento: ")
                                Dim documentoBuscar As String = Console.ReadLine()
                                Dim encontrado As Boolean = False
                                For i As Integer = 0 To cantidad - 1
                                    If documentos(i).ToLower() = documentoBuscar.ToLower() Then
                                        encontrado = True
                                        Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Telefono: " & telefonos(i) & " | Persona visitada: " & personasVisitadas(i) & " | Area: " & areas(i) & " | Motivo: " & motivos(i) & " | Entrada: " & horasEntrada(i) & " | Salida: " & horasSalida(i) & " | Estado: " & estados(i))
                                    End If
                                Next
                                If encontrado = False Then
                                    Console.WriteLine("No se encontro el visitante.")
                                End If
                            '---------------------------------'
                            '--|buscar_por_persona_visitada|--'
                            '---------------------------------'
                            Case 4
                                Console.Write("Ingrese la persona visitada: ")
                                Dim personaBuscar As String = Console.ReadLine()
                                Dim encontrado As Boolean = False
                                For i As Integer = 0 To cantidad - 1
                                    If personasVisitadas(i).ToLower().Contains(personaBuscar.ToLower()) Then
                                        encontrado = True
                                        Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Telefono: " & telefonos(i) & " | Persona visitada: " & personasVisitadas(i) & " | Area: " & areas(i) & " | Motivo: " & motivos(i) & " | Entrada: " & horasEntrada(i) & " | Salida: " & horasSalida(i) & " | Estado: " & estados(i))
                                    End If
                                Next
                                If encontrado = False Then
                                    Console.WriteLine("No se encontraron visitantes.")
                                End If
                            '---------------------'
                            '--|buscar_por_area|--'
                            '---------------------'
                            Case 5
                                Console.Write("Ingrese el area: ")
                                Dim areaBuscar As String = Console.ReadLine()
                                Dim encontrado As Boolean = False
                                For i As Integer = 0 To cantidad - 1
                                    If areas(i).ToLower().Contains(areaBuscar.ToLower()) Then
                                        encontrado = True
                                        Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Telefono: " & telefonos(i) & " | Persona visitada: " & personasVisitadas(i) & " | Area: " & areas(i) & " | Motivo: " & motivos(i) & " | Entrada: " & horasEntrada(i) & " | Salida: " & horasSalida(i) & " | Estado: " & estados(i))
                                    End If
                                Next
                                If encontrado = False Then
                                    Console.WriteLine("No se encontraron visitantes.")
                                End If
                            '-----------------------'
                            '--|buscar_por_estado|--'
                            '-----------------------'
                            Case 6
                                Console.Write("Ingrese el estado (En visita/Finalizada/Cancelada): ")
                                Dim estadoBuscar As String = Console.ReadLine()
                                Dim encontrado As Boolean = False
                                For i As Integer = 0 To cantidad - 1
                                    If estados(i).ToLower() = estadoBuscar.ToLower() Then
                                        encontrado = True
                                        Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Telefono: " & telefonos(i) & " | Persona visitada: " & personasVisitadas(i) & " | Area: " & areas(i) & " | Motivo: " & motivos(i) & " | Entrada: " & horasEntrada(i) & " | Salida: " & horasSalida(i) & " | Estado: " & estados(i))
                                    End If
                                Next
                                If encontrado = False Then
                                    Console.WriteLine("No se encontraron visitantes.")
                                End If
                            '-------------------'
                            '--|mostrar_todos|--'
                            '-------------------'
                            Case 7
                                For i As Integer = 0 To cantidad - 1
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Telefono: " & telefonos(i) & " | Persona visitada: " & personasVisitadas(i) & " | Area: " & areas(i) & " | Motivo: " & motivos(i) & " | Entrada: " & horasEntrada(i) & " | Salida: " & horasSalida(i) & " | Estado: " & estados(i))
                                Next
                            Case Else
                                Console.WriteLine("Opcion de busqueda no valida.")
                        End Select
                    End If
                '------------------------'
                '--|eliminar_visitante|--'
                '------------------------'
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No hay visitantes registrados.")
                    Else
                        Console.Write("Ingrese el ID del visitante: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        Dim encontrado As Boolean = False
                        For i As Integer = 0 To cantidad - 1
                            If ids(i) = idEliminar Then
                                encontrado = True
                                For j As Integer = i To cantidad - 2
                                    ids(j) = ids(j + 1)
                                    nombres(j) = nombres(j + 1)
                                    documentos(j) = documentos(j + 1)
                                    telefonos(j) = telefonos(j + 1)
                                    personasVisitadas(j) = personasVisitadas(j + 1)
                                    areas(j) = areas(j + 1)
                                    motivos(j) = motivos(j + 1)
                                    horasEntrada(j) = horasEntrada(j + 1)
                                    horasSalida(j) = horasSalida(j + 1)
                                    estados(j) = estados(j + 1)
                                Next
                                cantidad -= 1
                                ids(cantidad) = 0
                                nombres(cantidad) = ""
                                documentos(cantidad) = ""
                                telefonos(cantidad) = ""
                                personasVisitadas(cantidad) = ""
                                areas(cantidad) = ""
                                motivos(cantidad) = ""
                                horasEntrada(cantidad) = ""
                                horasSalida(cantidad) = ""
                                estados(cantidad) = ""
                                For j As Integer = 0 To cantidad - 1
                                    ids(j) = j + 1
                                Next
                                Console.WriteLine("Visitante eliminado correctamente.")
                                Exit For
                            End If
                        Next
                        If encontrado = False Then
                            Console.WriteLine("No se encontro un visitante con ese ID.")
                        End If
                    End If
                '-----------------------'
                '--|controlar_visitas|--'
                '-----------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No hay visitantes registrados.")
                    Else
                        Console.WriteLine("1) Mostrar visitas en curso")
                        Console.WriteLine("2) Finalizar visita")
                        Console.WriteLine("3) Cancelar visita")
                        Console.WriteLine("4) Mostrar visitas finalizadas")
                        Console.WriteLine("5) Mostrar visitas canceladas")
                        Console.WriteLine("6) Mostrar todas las visitas")
                        Console.WriteLine("7) Volver")
                        Console.Write("Seleccione una opcion: ")
                        Dim opcionControl As Integer = Convert.ToInt32(Console.ReadLine())
                        Select Case opcionControl
                            '------------------------------'
                            '--|mostrar_visitas_en_curso|--'
                            '------------------------------'
                            Case 1
                                Dim hayVisitas As Boolean = False
                                For i As Integer = 0 To cantidad - 1
                                    If estados(i) = "En visita" Then
                                        hayVisitas = True
                                        Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Telefono: " & telefonos(i) & " | Persona visitada: " & personasVisitadas(i) & " | Area: " & areas(i) & " | Motivo: " & motivos(i) & " | Entrada: " & horasEntrada(i) & " | Salida: " & horasSalida(i) & " | Estado: " & estados(i))
                                    End If
                                Next
                                If hayVisitas = False Then
                                    Console.WriteLine("No hay visitas en curso.")
                                End If
                            '----------------------'
                            '--|finalizar_visita|--'
                            '----------------------'
                            Case 2
                                Console.Write("Ingrese el ID de la visita: ")
                                Dim idFinalizar As Integer = Convert.ToInt32(Console.ReadLine())
                                Dim encontrado As Boolean = False
                                For i As Integer = 0 To cantidad - 1
                                    If ids(i) = idFinalizar Then
                                        encontrado = True
                                        If estados(i) = "En visita" Then
                                            Console.Write("Ingrese la hora de salida: ")
                                            Dim nuevaHoraSalida As String = Console.ReadLine()
                                            If nuevaHoraSalida = "" Then
                                                Console.WriteLine("La hora de salida no puede estar vacia.")
                                            Else
                                                horasSalida(i) = nuevaHoraSalida
                                                estados(i) = "Finalizada"
                                                Console.WriteLine("Visita finalizada correctamente.")
                                                Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Telefono: " & telefonos(i) & " | Persona visitada: " & personasVisitadas(i) & " | Area: " & areas(i) & " | Motivo: " & motivos(i) & " | Entrada: " & horasEntrada(i) & " | Salida: " & horasSalida(i) & " | Estado: " & estados(i))
                                            End If
                                        Else
                                            Console.WriteLine("La visita no se encuentra en curso.")
                                        End If
                                    End If
                                Next
                                If encontrado = False Then
                                    Console.WriteLine("No se encontro una visita con ese ID.")
                                End If
                            '---------------------'
                            '--|cancelar_visita|--'
                            '---------------------'
                            Case 3
                                Console.Write("Ingrese el ID de la visita: ")
                                Dim idCancelar As Integer = Convert.ToInt32(Console.ReadLine())
                                Dim encontrado As Boolean = False
                                For i As Integer = 0 To cantidad - 1
                                    If ids(i) = idCancelar Then
                                        encontrado = True
                                        If estados(i) = "En visita" Then
                                            estados(i) = "Cancelada"
                                            Console.WriteLine("Visita cancelada correctamente.")
                                        Else
                                            Console.WriteLine("La visita no se encuentra en curso.")
                                        End If
                                    End If
                                Next
                                If encontrado = False Then
                                    Console.WriteLine("No se encontro una visita con ese ID.")
                                End If
                            '---------------------------------'
                            '--|mostrar_visitas_finalizadas|--'
                            '---------------------------------'
                            Case 4
                                Dim hayVisitas As Boolean = False
                                For i As Integer = 0 To cantidad - 1
                                    If estados(i) = "Finalizada" Then
                                        hayVisitas = True
                                        Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Telefono: " & telefonos(i) & " | Persona visitada: " & personasVisitadas(i) & " | Area: " & areas(i) & " | Motivo: " & motivos(i) & " | Entrada: " & horasEntrada(i) & " | Salida: " & horasSalida(i) & " | Estado: " & estados(i))
                                    End If
                                Next
                                If hayVisitas = False Then
                                    Console.WriteLine("No hay visitas finalizadas.")
                                End If
                            '--------------------------------'
                            '--|mostrar_visitas_canceladas|--'
                            '--------------------------------'
                            Case 5
                                Dim hayVisitas As Boolean = False
                                For i As Integer = 0 To cantidad - 1
                                    If estados(i) = "Cancelada" Then
                                        hayVisitas = True
                                        Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Telefono: " & telefonos(i) & " | Persona visitada: " & personasVisitadas(i) & " | Area: " & areas(i) & " | Motivo: " & motivos(i) & " | Entrada: " & horasEntrada(i) & " | Salida: " & horasSalida(i) & " | Estado: " & estados(i))
                                    End If
                                Next
                                If hayVisitas = False Then
                                    Console.WriteLine("No hay visitas canceladas.")
                                End If
                            '-------------------------------'
                            '--|mostrar_todas_las_visitas|--'
                            '-------------------------------'
                            Case 6
                                For i As Integer = 0 To cantidad - 1
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Telefono: " & telefonos(i) & " | Persona visitada: " & personasVisitadas(i) & " | Area: " & areas(i) & " | Motivo: " & motivos(i) & " | Entrada: " & horasEntrada(i) & " | Salida: " & horasSalida(i) & " | Estado: " & estados(i))
                                Next
                            '------------'
                            '--|volver|--'
                            '------------'
                            Case 7
                                Console.WriteLine("Regresando al menu principal...")
                            Case Else
                                Console.WriteLine("Opcion de control no valida.")
                        End Select
                    End If
                '---------------------'
                '--|mostrar_resumen|--'
                '---------------------'
                Case 7
                    If cantidad = 0 Then
                        Console.WriteLine("No hay visitantes registrados.")
                    Else
                        Dim enVisita As Integer = 0
                        Dim finalizadas As Integer = 0
                        Dim canceladas As Integer = 0
                        For i As Integer = 0 To cantidad - 1
                            If estados(i) = "En visita" Then
                                enVisita += 1
                            ElseIf estados(i) = "Finalizada" Then
                                finalizadas += 1
                            ElseIf estados(i) = "Cancelada" Then
                                canceladas += 1
                            End If
                        Next
                        Dim porcentajeFinalizadas As Double = (finalizadas * 100) / cantidad
                        Dim porcentajeCanceladas As Double = (canceladas * 100) / cantidad
                        Console.WriteLine("Total de visitantes: " & cantidad)
                        Console.WriteLine("Visitas en curso: " & enVisita)
                        Console.WriteLine("Visitas finalizadas: " & finalizadas)
                        Console.WriteLine("Visitas canceladas: " & canceladas)
                        Console.WriteLine("Porcentaje de visitas finalizadas: " & porcentajeFinalizadas.ToString("0.00") & "%")
                        Console.WriteLine("Porcentaje de visitas canceladas: " & porcentajeCanceladas.ToString("0.00") & "%")
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 8
                    Console.WriteLine("Programa finalizado.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 8
    End Sub
End Module