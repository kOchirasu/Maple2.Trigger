namespace Maple2.Trigger._02000247_bf {
    public static class _elevator {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042, 1043, 1044, 1045, 1046, 1047, 1048, 1049, 1050, 1051, 1052, 1053, 1054, 1055, 1056, 1057, 1058, 1059, 1060, 1061, 1062, 1063, 1064, 1065, 1066, 1067, 1068, 1069, 1070, 1071, 1072, 1073}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {401})) {
                    return new State엘리베이터00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리베이터00 : TriggerState {
            internal State엘리베이터00(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {402})) {
                    return new State엘리베이터01(context);
                }

                if (!context.UserDetected(arg1: new[] {999})) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리베이터01 : TriggerState {
            internal State엘리베이터01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {403})) {
                    return new State엘리베이터02(context);
                }

                if (!context.UserDetected(arg1: new[] {999})) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리베이터02 : TriggerState {
            internal State엘리베이터02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {404})) {
                    return new State엘리베이터03(context);
                }

                if (!context.UserDetected(arg1: new[] {401})) {
                    return new State대기(context);
                }

                if (!context.UserDetected(arg1: new[] {402})) {
                    return new State대기(context);
                }

                if (!context.UserDetected(arg1: new[] {403})) {
                    return new State대기(context);
                }

                if (!context.UserDetected(arg1: new[] {404})) {
                    return new State대기(context);
                }

                if (!context.UserDetected(arg1: new[] {999})) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리베이터03 : TriggerState {
            internal State엘리베이터03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 10);
                context.SetMesh(arg1: new[] {301, 302, 303, 304}, arg2: false);
                context.SetBreakable(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042, 1043, 1044, 1045, 1046, 1047, 1048, 1049, 1050, 1051, 1052, 1053, 1054, 1055, 1056, 1057, 1058, 1059, 1060, 1061, 1062, 1063, 1064, 1065, 1066, 1067, 1068, 1069, 1070, 1071, 1072, 1073}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State대기(context);
                }

                if (!context.UserDetected(arg1: new[] {999})) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}