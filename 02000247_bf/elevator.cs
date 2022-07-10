namespace Maple2.Trigger._02000247_bf {
    public static class _elevator {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042, 1043, 1044, 1045, 1046, 1047, 1048, 1049, 1050, 1051, 1052, 1053, 1054, 1055, 1056, 1057, 1058, 1059, 1060, 1061, 1062, 1063, 1064, 1065, 1066, 1067, 1068, 1069, 1070, 1071, 1072, 1073}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{401})) {
                    return new State엘리베이터00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리베이터00 : TriggerState {
            internal State엘리베이터00(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{402})) {
                    return new State엘리베이터01(context);
                }

                if (!context.UserDetected(boxIds: new []{999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리베이터01 : TriggerState {
            internal State엘리베이터01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{403})) {
                    return new State엘리베이터02(context);
                }

                if (!context.UserDetected(boxIds: new []{999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리베이터02 : TriggerState {
            internal State엘리베이터02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{404})) {
                    return new State엘리베이터03(context);
                }

                if (!context.UserDetected(boxIds: new []{401})) {
                    return new StateWait(context);
                }

                if (!context.UserDetected(boxIds: new []{402})) {
                    return new StateWait(context);
                }

                if (!context.UserDetected(boxIds: new []{403})) {
                    return new StateWait(context);
                }

                if (!context.UserDetected(boxIds: new []{404})) {
                    return new StateWait(context);
                }

                if (!context.UserDetected(boxIds: new []{999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리베이터03 : TriggerState {
            internal State엘리베이터03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 10);
                context.SetMesh(triggerIds: new []{301, 302, 303, 304}, visible: false);
                context.SetBreakable(triggerIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042, 1043, 1044, 1045, 1046, 1047, 1048, 1049, 1050, 1051, 1052, 1053, 1054, 1055, 1056, 1057, 1058, 1059, 1060, 1061, 1062, 1063, 1064, 1065, 1066, 1067, 1068, 1069, 1070, 1071, 1072, 1073}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateWait(context);
                }

                if (!context.UserDetected(boxIds: new []{999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
