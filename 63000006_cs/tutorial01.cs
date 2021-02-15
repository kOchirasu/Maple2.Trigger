namespace Maple2.Trigger._63000006_cs {
    public static class _tutorial01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "Guide");
                context.SetPortal(arg1: 1, arg2: true, arg3: false, arg4: true);
                context.SetSkill(arg1: new[] {900, 901, 902, 903, 904, 905, 906, 907}, arg2: false);
                context.SetMesh(arg1: new[] {3000, 3001, 3002, 3003}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {5011, 5012, 5013, 5014, 5015, 5000, 5001, 5012, 5013, 5020, 5021, 5022, 5023, 5024, 5025, 5026, 5027, 5028, 5040, 5041, 5042, 5043, 5044, 5045, 5046, 5047, 5048, 5050, 5051, 5052, 5060, 5061, 5062, 5063, 5064, 5065, 5066, 5080, 5090}, arg2: false);
                context.CreateMonster(arg1: new[] {101}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new State영상Prepare_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상Prepare_01 : TriggerState {
            internal State영상Prepare_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State영상재생_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상재생_01 : TriggerState {
            internal State영상재생_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: @"common\Common_Opening.usm", movieId: 1);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new State룬블영상Prepare_01(context);
                }

                if (context.WaitTick(waitTick: 190000)) {
                    return new State룬블영상Prepare_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State룬블영상Prepare_01 : TriggerState {
            internal State룬블영상Prepare_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State룬블영상재생_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State룬블영상재생_01 : TriggerState {
            internal State룬블영상재생_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: @"common\RuneBlader_Intro.usm", movieId: 2);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "2")) {
                    return new State룬블영상완료_01(context);
                }

                if (context.WaitTick(waitTick: 30000)) {
                    return new State룬블영상완료_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State룬블영상완료_01 : TriggerState {
            internal State룬블영상완료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State키타입설정안내01(context);
                }

                if (context.UserDetected(arg1: new[] {9050, 9051, 9052, 9053})) {
                    return new State로딩Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State키타입설정안내01 : TriggerState {
            internal State키타입설정안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuideEvent(eventId: 10010005);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "Guide", arg2: "IsTriggerEvent", arg3: "10010009")) {
                    return new State플레이Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State플레이Prepare : TriggerState {
            internal State플레이Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10010001, textId: 10010001);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9050, 9051, 9052, 9053})) {
                    return new State로딩Delay(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10010001);
            }
        }

        private class State로딩Delay : TriggerState {
            internal State로딩Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State기상Prepare01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기상Prepare01 : TriggerState {
            internal State기상Prepare01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 1);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_999");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State기상대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기상대화01 : TriggerState {
            internal State기상대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 4);
                context.SetEffect(arg1: new[] {5060}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$63000006_CS__TUTORIAL01__0$", arg4: 4);
                context.SetSkip(arg1: "움직이기01");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State움직이기01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }
        }

        private class State움직이기01 : TriggerState {
            internal State움직이기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000, 5001, 5050}, arg2: true);
                context.ShowGuideSummary(entityId: 10010000, textId: 10010000);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {6001})) {
                    return new State움직이기02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {5060}, arg2: false);
            }
        }

        private class State움직이기02 : TriggerState {
            internal State움직이기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_998");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {6000})) {
                    return new State이동완료01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {5051}, arg2: true);
                context.HideGuideSummary(entityId: 10010000);
            }
        }

        private class State이동완료01 : TriggerState {
            internal State이동완료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000, 5001}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1000");
            }

            public override TriggerState Execute() {
                return new State이동전대화01(context);
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {5050}, arg2: false);
            }
        }

        private class State이동전대화01 : TriggerState {
            internal State이동전대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                return new State이동전대화02(context);
            }

            public override void OnExit() { }
        }

        private class State이동전대화02 : TriggerState {
            internal State이동전대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 4);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$63000006_CS__TUTORIAL01__1$", arg4: 3);
                context.SetEffect(arg1: new[] {5061}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new State이동전대화03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동전대화03 : TriggerState {
            internal State이동전대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 4);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$63000006_CS__TUTORIAL01__2$", arg4: 3);
                context.SetEffect(arg1: new[] {5061}, arg2: false);
                context.SetEffect(arg1: new[] {5062}, arg2: true);
                context.SetSkip(arg1: "미니맵가이드01");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State미니맵Guide01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }
        }

        private class State미니맵Guide01 : TriggerState {
            internal State미니맵Guide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuideEvent(eventId: 10010010);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "Guide", arg2: "IsTriggerEvent", arg3: "10010020")) {
                    return new StateIshura이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura이동01 : TriggerState {
            internal StateIshura이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 3);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$63000006_CS__TUTORIAL01__3$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    return new StateIshura이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura이동02 : TriggerState {
            internal StateIshura이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 1);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1001");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    return new StateIshura이동03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura이동03 : TriggerState {
            internal StateIshura이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "12", arg2: 4);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$63000006_CS__TUTORIAL01__4$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    return new StateIshura이동04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura이동04 : TriggerState {
            internal StateIshura이동04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "13", arg2: 4);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$63000006_CS__TUTORIAL01__5$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "13")) {
                    return new StateIshura이동05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura이동05 : TriggerState {
            internal StateIshura이동05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "14", arg2: 4);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$63000006_CS__TUTORIAL01__6$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "14")) {
                    return new State다리SetupCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리SetupCinematic : TriggerState {
            internal State다리SetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 8002, arg2: new[] {101})) {
                    return new State다리Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리Cinematic01 : TriggerState {
            internal State다리Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 4);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$63000006_CS__TUTORIAL01__7$", arg4: 3);
                context.SetEffect(arg1: new[] {5064}, arg2: true);
                context.SetSkip(arg1: "다리연출02");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    return new State다리Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class State다리Cinematic02 : TriggerState {
            internal State다리Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: true);
                context.SetEffect(arg1: new[] {5080}, arg2: true);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1002");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 8004, arg2: new[] {101})) {
                    return new State다리Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리Cinematic03 : TriggerState {
            internal State다리Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 8005, arg2: new[] {101})) {
                    return new State다리StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리StopCinematic : TriggerState {
            internal State다리StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$63000006_CS__TUTORIAL01__8$", arg4: 3);
                context.SetEffect(arg1: new[] {5080, 5064}, arg2: false);
                context.SetEffect(arg1: new[] {5011, 5012, 5013, 5014, 5015}, arg2: true);
                context.ShowGuideSummary(entityId: 10010020, textId: 10010020);
                context.SetEffect(arg1: new[] {5050, 5052}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State다리붕괴01(context);
            }

            public override void OnExit() { }
        }

        private class State다리붕괴01 : TriggerState {
            internal State다리붕괴01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9003})) {
                    return new State다리붕괴02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetMesh(arg1: new[] {3004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3002, 3003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.HideGuideSummary(entityId: 10010020);
                context.SetEffect(arg1: new[] {5050, 5052, 5011, 5012, 5013, 5014, 5015}, arg2: false);
            }
        }

        private class State다리붕괴02 : TriggerState {
            internal State다리붕괴02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {902, 906}, arg2: true);
                context.SetEffect(arg1: new[] {5090}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State다리붕괴03(context);
            }

            public override void OnExit() { }
        }

        private class State다리붕괴03 : TriggerState {
            internal State다리붕괴03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {900, 904, 901, 905}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State다리붕괴04(context);
            }

            public override void OnExit() { }
        }

        private class State다리붕괴04 : TriggerState {
            internal State다리붕괴04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {903}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State다리붕괴05(context);
            }

            public override void OnExit() { }
        }

        private class State다리붕괴05 : TriggerState {
            internal State다리붕괴05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {907}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9004})) {
                    return new State수영안내01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetSkill(arg1: new[] {901, 902, 903}, arg2: false);
                context.SetMesh(arg1: new[] {3001, 3004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }
        }

        private class State수영안내01 : TriggerState {
            internal State수영안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "30", arg2: 1);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetEffect(arg1: new[] {5090}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    return new State수영안내02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State수영안내02 : TriggerState {
            internal State수영안내02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "31", arg2: 4);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$63000006_CS__TUTORIAL01__9$", arg4: 3);
                context.SetEffect(arg1: new[] {5065}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "31")) {
                    return new State수영안내03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State수영안내03 : TriggerState {
            internal State수영안내03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "32", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$63000006_CS__TUTORIAL01__10$", arg4: 3);
                context.SetEffect(arg1: new[] {5065}, arg2: false);
                context.SetEffect(arg1: new[] {5066}, arg2: true);
                context.SetSkip(arg1: "Ishura교체");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "32")) {
                    return new StateIshura교체(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateIshura교체 : TriggerState {
            internal StateIshura교체(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10010030, textId: 10010030);
                context.SetEffect(arg1: new[] {5050, 5020, 5021, 5022, 5023, 5024, 5025, 5026, 5027, 5028}, arg2: true);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1003");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 8006, arg2: new[] {101})) {
                    return new StateCinematic05종료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {5066}, arg2: false);
            }
        }

        private class StateCinematic05종료 : TriggerState {
            internal StateCinematic05종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9010, 9011, 9012, 9013, 9014, 9015})) {
                    return new StateLadder유도01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10010030);
            }
        }

        private class StateLadder유도01 : TriggerState {
            internal StateLadder유도01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10010020, textId: 10010020);
                context.SetEffect(arg1: new[] {5050}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9006})) {
                    return new StateLadder유도02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10010020);
            }
        }

        private class StateLadder유도02 : TriggerState {
            internal StateLadder유도02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10010040, textId: 10010040);
                context.SetEffect(arg1: new[] {5050, 5040}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9005})) {
                    return new State언덕유도01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10010040);
            }
        }

        private class State언덕유도01 : TriggerState {
            internal State언덕유도01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10010020, textId: 10010020);
                context.SetEffect(arg1: new[] {5050, 5041, 5042, 5043, 5044, 5045, 5046, 5047, 5048}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9020})) {
                    return new State언덕유도02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10010020);
            }
        }

        private class State언덕유도02 : TriggerState {
            internal State언덕유도02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10010050, textId: 10010050);
                context.SetEffect(arg1: new[] {5050}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9021})) {
                    return new StateQuest수락유도01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10010050);
            }
        }

        private class StateQuest수락유도01 : TriggerState {
            internal StateQuest수락유도01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10010060, textId: 10010060);
                context.SetEffect(arg1: new[] {5050}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9030}, arg2: new[] {90000410}, arg3: new byte[] {1})) {
                    return new StatePortalCreation01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10010060);
                context.SetEffect(arg1: new[] {5040, 5041, 5042, 5043, 5044, 5045, 5046, 5020, 5021, 5022, 5023, 5024, 5025, 5026, 5027, 5028}, arg2: false);
            }
        }

        private class StatePortalCreation01 : TriggerState {
            internal StatePortalCreation01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "35", arg2: 1);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.GuideEvent(eventId: 10010080);
                context.ShowGuideSummary(entityId: 10010070, textId: 10010070);
                context.SetEffect(arg1: new[] {5050}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "35")) {
                    return new StateIshuraExit01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshuraExit01 : TriggerState {
            internal StateIshuraExit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$63000006_CS__TUTORIAL01__11$", arg4: 3);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_1004");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 8008, arg2: new[] {102})) {
                    return new StateIshuraExit02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {5050}, arg2: false);
            }
        }

        private class StateIshuraExit02 : TriggerState {
            internal StateIshuraExit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {102});
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {9040})) {
                    return new State맵이동완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State맵이동완료 : TriggerState {
            internal State맵이동완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 10010070);
                context.SetEffect(arg1: new[] {5047, 5048}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}