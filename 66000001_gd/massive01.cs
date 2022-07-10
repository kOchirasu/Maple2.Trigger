namespace Maple2.Trigger._66000001_gd {
    public static class _massive01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{301})) {
                    return new State퍼즐Waiting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐Waiting : TriggerState {
            internal State퍼즐Waiting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211}, visible: true);
                context.SetActor(triggerId: 251, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 252, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 253, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 254, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 255, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 256, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 257, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 258, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 259, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 260, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 261, visible: true, initialSequence: "Eff_MassiveEvent_Door_Opened");
                context.SetMesh(triggerIds: new []{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100}, visible: true);
                context.SetPortal(portalId: 777, visible: false, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 778, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 779, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 301) == 50) {
                    return new State계단없애기(context);
                }

                if (context.WaitTick(waitTick: 30000)) {
                    return new State계단없애기(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(triggerId: 261, visible: true, initialSequence: "Eff_MassiveEvent_Door_Vanished");
                context.SetPortal(portalId: 777, visible: false, enabled: false, minimapVisible: false);
            }
        }

        private class State계단없애기 : TriggerState {
            internal State계단없애기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMiniGameAreaForHack(boxId: 301);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State계단없애기2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetMesh(triggerIds: new []{206, 207, 208, 209, 210, 211}, visible: false);
                context.SetActor(triggerId: 256, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(triggerId: 257, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(triggerId: 258, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(triggerId: 259, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(triggerId: 260, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(triggerId: 261, visible: false, initialSequence: "Eff_MassiveEvent_Door_Vanished");
                context.ResetTimer(timerId: "1");
            }
        }

        private class State계단없애기2 : TriggerState {
            internal State계단없애기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateBeginWait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetMesh(triggerIds: new []{201, 202, 203, 204, 205}, visible: false);
                context.SetActor(triggerId: 251, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(triggerId: 252, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(triggerId: 253, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(triggerId: 254, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(triggerId: 255, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(triggerId: 256, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(triggerId: 257, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(triggerId: 258, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(triggerId: 259, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(triggerId: 260, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                context.ResetTimer(timerId: "1");
            }
        }

        private class StateBeginWait : TriggerState {
            internal StateBeginWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateMassiveEvent0(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class StateMassiveEvent0 : TriggerState {
            internal StateMassiveEvent0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$61000002_ME_002__MASSIVE01__0$", duration: 6000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateMassiveEvent1(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class StateMassiveEvent1 : TriggerState {
            internal StateMassiveEvent1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 4);
                context.SetEventUI(arg1: 1, script: "$66000001_GD__MASSIVE01__0$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateMassiveEvent2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class StateMassiveEvent2 : TriggerState {
            internal StateMassiveEvent2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$61000002_ME_002__MASSIVE01__2$", duration: 6000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateMassiveEvent3(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class StateMassiveEvent3 : TriggerState {
            internal StateMassiveEvent3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 6);
                context.SetEventUI(arg1: 0, script: "1,4");
                context.ShowCountUI(text: "$61000002_ME_002__MASSIVE01__3$", stage: 1, count: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State퍼즐단계1Wait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class State퍼즐단계1Wait : TriggerState {
            internal State퍼즐단계1Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State퍼즐단계1(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class State퍼즐단계1 : TriggerState {
            internal State퍼즐단계1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 40);
                context.SetRandomMesh(triggerIds: new []{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100}, visible: false, meshCount: 20, arg4: 0, delay: 2000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State퍼즐단계1정리(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class State퍼즐단계1정리 : TriggerState {
            internal State퍼즐단계1정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State퍼즐단계1정리2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class State퍼즐단계1정리2 : TriggerState {
            internal State퍼즐단계1정리2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{301})) {
                    context.SetEventUI(arg1: 0, script: "2,4");
                    context.ShowCountUI(text: "$61000002_ME_002__MASSIVE01__4$", stage: 2, count: 5);
                    return new State퍼즐단계2Wait(context);
                }

                if (!context.UserDetected(boxIds: new []{301})) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐단계2Wait : TriggerState {
            internal State퍼즐단계2Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 6);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State퍼즐단계2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class State퍼즐단계2 : TriggerState {
            internal State퍼즐단계2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 30);
                context.SetRandomMesh(triggerIds: new []{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100}, visible: false, meshCount: 30, arg4: 0, delay: 1000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State퍼즐단계2정리(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class State퍼즐단계2정리 : TriggerState {
            internal State퍼즐단계2정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State퍼즐단계2정리2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class State퍼즐단계2정리2 : TriggerState {
            internal State퍼즐단계2정리2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{301})) {
                    context.SetEventUI(arg1: 0, script: "3,4");
                    context.ShowCountUI(text: "$61000002_ME_002__MASSIVE01__5$", stage: 3, count: 5);
                    return new State퍼즐단계3Wait(context);
                }

                if (!context.UserDetected(boxIds: new []{301})) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐단계3Wait : TriggerState {
            internal State퍼즐단계3Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 6);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State퍼즐단계3(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class State퍼즐단계3 : TriggerState {
            internal State퍼즐단계3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 15);
                context.SetRandomMesh(triggerIds: new []{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100}, visible: false, meshCount: 30, arg4: 0, delay: 500);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State퍼즐단계3정리(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class State퍼즐단계3정리 : TriggerState {
            internal State퍼즐단계3정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State퍼즐단계3정리2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class State퍼즐단계3정리2 : TriggerState {
            internal State퍼즐단계3정리2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{301})) {
                    context.SetEventUI(arg1: 0, script: "4,4");
                    context.ShowCountUI(text: "$61000002_ME_002__MASSIVE01__6$", stage: 4, count: 5);
                    return new State퍼즐단계4Wait(context);
                }

                if (!context.UserDetected(boxIds: new []{301})) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퍼즐단계4Wait : TriggerState {
            internal State퍼즐단계4Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 6);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State퍼즐단계4(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class State퍼즐단계4 : TriggerState {
            internal State퍼즐단계4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 5);
                context.SetRandomMesh(triggerIds: new []{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100}, visible: false, meshCount: 15, arg4: 0, delay: 200);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State퍼즐단계4정리(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class State퍼즐단계4정리 : TriggerState {
            internal State퍼즐단계4정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State퍼즐단계4정리2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class State퍼즐단계4정리2 : TriggerState {
            internal State퍼즐단계4정리2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{301})) {
                    context.SetMesh(triggerIds: new []{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100}, visible: true);
                    return new State보상단계(context);
                }

                if (!context.UserDetected(boxIds: new []{301})) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보상단계 : TriggerState {
            internal State보상단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 7);
                context.SetEventUI(arg1: 0, script: "0,0");
                context.SetEventUI(arg1: 3, script: "$61000002_ME_002__MASSIVE01__7$", duration: 7000, boxId: 301);
                context.SetEventUI(arg1: 6, script: "$61000002_ME_002__MASSIVE01__8$", duration: 7000, notBoxId: 301);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State경험치지급(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class State경험치지급 : TriggerState {
            internal State경험치지급(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateBuff걸기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff걸기 : TriggerState {
            internal StateBuff걸기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 7);
                context.SetEventUI(arg1: 0, script: "0,0");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State퍼즐종료계단보이기(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class State퍼즐종료계단보이기 : TriggerState {
            internal State퍼즐종료계단보이기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "0,0");
                context.SetMesh(triggerIds: new []{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 201, 202, 203, 204, 205}, visible: true);
                context.SetActor(triggerId: 251, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 252, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 253, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 254, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 255, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State퍼즐종료계단보이기2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class State퍼즐종료계단보이기2 : TriggerState {
            internal State퍼즐종료계단보이기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{206, 207, 208, 209, 210}, visible: true);
                context.SetActor(triggerId: 256, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 257, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 258, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 259, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 260, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State퍼즐종료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetMesh(triggerIds: new []{211}, visible: true);
                context.SetActor(triggerId: 261, visible: true, initialSequence: "Eff_MassiveEvent_Door_Opened");
                context.ResetTimer(timerId: "1");
            }
        }

        private class State퍼즐종료 : TriggerState {
            internal State퍼즐종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.UnSetMiniGameAreaForHack();
                context.SetEventUI(arg1: 0, script: "0,0");
                context.SetPortal(portalId: 777, visible: false, enabled: true, minimapVisible: false);
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 0, script: "0,0");
                context.SetEventUI(arg1: 5, script: "$61000002_ME_002__MASSIVE01__13$", duration: 5000);
                context.SetMesh(triggerIds: new []{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100}, visible: true);
                context.SetPortal(portalId: 777, visible: false, enabled: true, minimapVisible: false);
                context.SetMesh(triggerIds: new []{201, 202, 203, 204, 205}, visible: true);
                context.SetActor(triggerId: 251, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 252, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 253, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 254, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 255, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State실패계단보이기2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class State실패계단보이기2 : TriggerState {
            internal State실패계단보이기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{206, 207, 208, 209, 210}, visible: true);
                context.SetActor(triggerId: 256, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 257, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 258, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 259, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(triggerId: 260, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State유저이동(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetMesh(triggerIds: new []{211}, visible: true);
                context.SetActor(triggerId: 261, visible: true, initialSequence: "Eff_MassiveEvent_Door_Opened");
                context.ResetTimer(timerId: "1");
            }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000007_ME__MAINPROCESS_SPRINGBEACH__23$", duration: 5000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 120000)) {
                    context.MoveUser(mapId: 0, portalId: 0);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
