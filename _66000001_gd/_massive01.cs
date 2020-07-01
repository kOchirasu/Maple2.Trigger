namespace Maple2.Trigger._66000001_gd {
    public static class _massive01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {301})) {
                    return new State퍼즐대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐대기중 : TriggerState {
            internal State퍼즐대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211}, arg2: true);
                context.SetActor(arg1: 251, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 252, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 253, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 254, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 255, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 256, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 257, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 258, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 259, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 260, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 261, arg2: true, arg3: "Eff_MassiveEvent_Door_Opened");
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100}, arg2: true);
                context.SetPortal(arg1: 777, arg2: false, arg3: true, arg4: false);
                context.SetPortal(arg1: 778, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 779, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 301) == 50) {
                    return new State계단없애기(context);
                }

                if (context.WaitTick(waitTick: 30000)) {
                    return new State계단없애기(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(arg1: 261, arg2: true, arg3: "Eff_MassiveEvent_Door_Vanished");
                context.SetPortal(arg1: 777, arg2: false, arg3: false, arg4: false);
            }
        }

        private class State계단없애기 : TriggerState {
            internal State계단없애기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMiniGameAreaForHack(boxId: 301);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State계단없애기2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetMesh(arg1: new[] {206, 207, 208, 209, 210, 211}, arg2: false);
                context.SetActor(arg1: 256, arg2: true, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 257, arg2: true, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 258, arg2: true, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 259, arg2: true, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 260, arg2: true, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 261, arg2: false, arg3: "Eff_MassiveEvent_Door_Vanished");
                context.ResetTimer(arg1: "1");
            }
        }

        private class State계단없애기2 : TriggerState {
            internal State계단없애기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State시작대기(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetMesh(arg1: new[] {201, 202, 203, 204, 205}, arg2: false);
                context.SetActor(arg1: 251, arg2: true, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 252, arg2: true, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 253, arg2: true, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 254, arg2: true, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 255, arg2: true, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 256, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 257, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 258, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 259, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 260, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.ResetTimer(arg1: "1");
            }
        }

        private class State시작대기 : TriggerState {
            internal State시작대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State멘트0(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State멘트0 : TriggerState {
            internal State멘트0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$61000002_ME_002__MASSIVE01__0$", arg3: 6000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State멘트1(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State멘트1 : TriggerState {
            internal State멘트1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 4);
                context.SetEventUI(arg1: 1, arg2: "$66000001_GD__MASSIVE01__0$", arg3: 4000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State멘트2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State멘트2 : TriggerState {
            internal State멘트2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 5);
                context.SetEventUI(arg1: 1, arg2: "$61000002_ME_002__MASSIVE01__2$", arg3: 6000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State멘트3(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State멘트3 : TriggerState {
            internal State멘트3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 6);
                context.SetEventUI(arg1: 0, arg2: "1,4");
                context.ShowCountUI(text: "$61000002_ME_002__MASSIVE01__3$", stage: 1, count: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐단계1대기(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계1대기 : TriggerState {
            internal State퍼즐단계1대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐단계1(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계1 : TriggerState {
            internal State퍼즐단계1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 40);
                context.SetRandomMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100}, arg2: false, arg3: 20, arg4: 0, arg5: 2000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐단계1정리(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계1정리 : TriggerState {
            internal State퍼즐단계1정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐단계1정리2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계1정리2 : TriggerState {
            internal State퍼즐단계1정리2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {301})) {
                    context.SetEventUI(arg1: 0, arg2: "2,4");
                    context.ShowCountUI(text: "$61000002_ME_002__MASSIVE01__4$", stage: 2, count: 5);
                    return new State퍼즐단계2대기(context);
                }

                if (!context.UserDetected(arg1: new[] {301})) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐단계2대기 : TriggerState {
            internal State퍼즐단계2대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 6);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐단계2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계2 : TriggerState {
            internal State퍼즐단계2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30);
                context.SetRandomMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100}, arg2: false, arg3: 30, arg4: 0, arg5: 1000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐단계2정리(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계2정리 : TriggerState {
            internal State퍼즐단계2정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐단계2정리2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계2정리2 : TriggerState {
            internal State퍼즐단계2정리2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {301})) {
                    context.SetEventUI(arg1: 0, arg2: "3,4");
                    context.ShowCountUI(text: "$61000002_ME_002__MASSIVE01__5$", stage: 3, count: 5);
                    return new State퍼즐단계3대기(context);
                }

                if (!context.UserDetected(arg1: new[] {301})) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐단계3대기 : TriggerState {
            internal State퍼즐단계3대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 6);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐단계3(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계3 : TriggerState {
            internal State퍼즐단계3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 15);
                context.SetRandomMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100}, arg2: false, arg3: 30, arg4: 0, arg5: 500);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐단계3정리(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계3정리 : TriggerState {
            internal State퍼즐단계3정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐단계3정리2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계3정리2 : TriggerState {
            internal State퍼즐단계3정리2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {301})) {
                    context.SetEventUI(arg1: 0, arg2: "4,4");
                    context.ShowCountUI(text: "$61000002_ME_002__MASSIVE01__6$", stage: 4, count: 5);
                    return new State퍼즐단계4대기(context);
                }

                if (!context.UserDetected(arg1: new[] {301})) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐단계4대기 : TriggerState {
            internal State퍼즐단계4대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 6);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐단계4(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계4 : TriggerState {
            internal State퍼즐단계4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 5);
                context.SetRandomMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100}, arg2: false, arg3: 15, arg4: 0, arg5: 200);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐단계4정리(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계4정리 : TriggerState {
            internal State퍼즐단계4정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐단계4정리2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계4정리2 : TriggerState {
            internal State퍼즐단계4정리2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {301})) {
                    context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100}, arg2: true);
                    return new State보상단계(context);
                }

                if (!context.UserDetected(arg1: new[] {301})) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보상단계 : TriggerState {
            internal State보상단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 7);
                context.SetEventUI(arg1: 0, arg2: "0,0");
                context.SetEventUI(arg1: 3, arg2: "$61000002_ME_002__MASSIVE01__7$", arg3: 7000, arg4: "301");
                context.SetEventUI(arg1: 6, arg2: "$61000002_ME_002__MASSIVE01__8$", arg3: 7000, arg4: "!301");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State경험치지급(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State경험치지급 : TriggerState {
            internal State경험치지급(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State버프걸기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버프걸기 : TriggerState {
            internal State버프걸기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 7);
                context.SetEventUI(arg1: 0, arg2: "0,0");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐종료계단보이기(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐종료계단보이기 : TriggerState {
            internal State퍼즐종료계단보이기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "0,0");
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 201, 202, 203, 204, 205}, arg2: true);
                context.SetActor(arg1: 251, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 252, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 253, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 254, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 255, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐종료계단보이기2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐종료계단보이기2 : TriggerState {
            internal State퍼즐종료계단보이기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {206, 207, 208, 209, 210}, arg2: true);
                context.SetActor(arg1: 256, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 257, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 258, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 259, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 260, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State퍼즐종료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetMesh(arg1: new[] {211}, arg2: true);
                context.SetActor(arg1: 261, arg2: true, arg3: "Eff_MassiveEvent_Door_Opened");
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐종료 : TriggerState {
            internal State퍼즐종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.UnSetMiniGameAreaForHack();
                context.SetEventUI(arg1: 0, arg2: "0,0");
                context.SetPortal(arg1: 777, arg2: false, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State유저이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.UnSetMiniGameAreaForHack();
                context.SetEventUI(arg1: 0, arg2: "0,0");
                context.SetEventUI(arg1: 5, arg2: "$61000002_ME_002__MASSIVE01__13$", arg3: 5000);
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100}, arg2: true);
                context.SetPortal(arg1: 777, arg2: false, arg3: true, arg4: false);
                context.SetMesh(arg1: new[] {201, 202, 203, 204, 205}, arg2: true);
                context.SetActor(arg1: 251, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 252, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 253, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 254, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 255, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State실패계단보이기2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State실패계단보이기2 : TriggerState {
            internal State실패계단보이기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {206, 207, 208, 209, 210}, arg2: true);
                context.SetActor(arg1: 256, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 257, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 258, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 259, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 260, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State유저이동(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetMesh(arg1: new[] {211}, arg2: true);
                context.SetActor(arg1: 261, arg2: true, arg3: "Eff_MassiveEvent_Door_Opened");
                context.ResetTimer(arg1: "1");
            }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$61000007_ME__MAINPROCESS_SPRINGBEACH__23$", arg3: 5000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 120000)) {
                    context.MoveUser(arg1: 0, arg2: 0);
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}