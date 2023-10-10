using Maple2.Trigger.Enum;

namespace Maple2.Trigger._63000006_cs {
    public static class _tutorial01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.Guide);
                context.SetPortal(portalId: 1, visible: true, enabled: false, minimapVisible: true);
                context.SetSkill(triggerIds: new []{900, 901, 902, 903, 904, 905, 906, 907}, enabled: false);
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{5011, 5012, 5013, 5014, 5015, 5000, 5001, 5012, 5013, 5020, 5021, 5022, 5023, 5024, 5025, 5026, 5027, 5028, 5040, 5041, 5042, 5043, 5044, 5045, 5046, 5047, 5048, 5050, 5051, 5052, 5060, 5061, 5062, 5063, 5064, 5065, 5066, 5080, 5090}, visible: false);
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new State영상Prepare_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상Prepare_01 : TriggerState {
            internal State영상Prepare_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
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
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.PlaySceneMovie(fileName: @"common\Common_Opening.usm", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
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

            public override TriggerState? Execute() {
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
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.PlaySceneMovie(fileName: @"common\RuneBlader_Intro.usm", movieId: 2);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "2")) {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State키타입설정안내01(context);
                }

                if (context.UserDetected(boxIds: new []{9050, 9051, 9052, 9053})) {
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

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.Guide, condition: "IsTriggerEvent", value: "10010009")) {
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

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9050, 9051, 9052, 9053})) {
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
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State기상Prepare01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기상Prepare01 : TriggerState {
            internal State기상Prepare01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 1);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_999");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State기상대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기상대화01 : TriggerState {
            internal State기상대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 4);
                context.SetEffect(triggerIds: new []{5060}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$63000006_CS__TUTORIAL01__0$", arg4: 4);
                context.SetSkip(state: new State움직이기01(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State움직이기01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State움직이기01 : TriggerState {
            internal State움직이기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000, 5001, 5050}, visible: true);
                context.ShowGuideSummary(entityId: 10010000, textId: 10010000);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{6001})) {
                    return new State움직이기02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{5060}, visible: false);
            }
        }

        private class State움직이기02 : TriggerState {
            internal State움직이기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_998");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{6000})) {
                    return new State이동완료01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{5051}, visible: true);
                context.HideGuideSummary(entityId: 10010000);
            }
        }

        private class State이동완료01 : TriggerState {
            internal State이동완료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000, 5001}, visible: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_1000");
            }

            public override TriggerState? Execute() {
                return new State이동전대화01(context);
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{5050}, visible: false);
            }
        }

        private class State이동전대화01 : TriggerState {
            internal State이동전대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                return new State이동전대화02(context);
            }

            public override void OnExit() { }
        }

        private class State이동전대화02 : TriggerState {
            internal State이동전대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "4", seconds: 4);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$63000006_CS__TUTORIAL01__1$", arg4: 3);
                context.SetEffect(triggerIds: new []{5061}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new State이동전대화03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동전대화03 : TriggerState {
            internal State이동전대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 4);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$63000006_CS__TUTORIAL01__2$", arg4: 3);
                context.SetEffect(triggerIds: new []{5061}, visible: false);
                context.SetEffect(triggerIds: new []{5062}, visible: true);
                context.SetSkip(state: new State미니맵Guide01(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State미니맵Guide01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State미니맵Guide01 : TriggerState {
            internal State미니맵Guide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuideEvent(eventId: 10010010);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.Guide, condition: "IsTriggerEvent", value: "10010020")) {
                    return new StateIshura이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura이동01 : TriggerState {
            internal StateIshura이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 3);
                context.SetConversation(type: 1, spawnId: 101, script: "$63000006_CS__TUTORIAL01__3$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new StateIshura이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura이동02 : TriggerState {
            internal StateIshura이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "11", seconds: 1);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_1001");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11")) {
                    return new StateIshura이동03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura이동03 : TriggerState {
            internal StateIshura이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "12", seconds: 4);
                context.SetConversation(type: 1, spawnId: 101, script: "$63000006_CS__TUTORIAL01__4$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "12")) {
                    return new StateIshura이동04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura이동04 : TriggerState {
            internal StateIshura이동04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "13", seconds: 4);
                context.SetConversation(type: 1, spawnId: 101, script: "$63000006_CS__TUTORIAL01__5$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "13")) {
                    return new StateIshura이동05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura이동05 : TriggerState {
            internal StateIshura이동05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "14", seconds: 4);
                context.SetConversation(type: 1, spawnId: 101, script: "$63000006_CS__TUTORIAL01__6$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "14")) {
                    return new State다리SetupCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리SetupCinematic : TriggerState {
            internal State다리SetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 8002, spawnIds: new []{101})) {
                    return new State다리Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리Cinematic01 : TriggerState {
            internal State다리Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "20", seconds: 4);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$63000006_CS__TUTORIAL01__7$", arg4: 3);
                context.SetEffect(triggerIds: new []{5064}, visible: true);
                context.SetSkip(state: new State다리Cinematic02(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "20")) {
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
                context.CameraSelect(triggerId: 601, enabled: true);
                context.SetEffect(triggerIds: new []{5080}, visible: true);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_1002");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 8004, spawnIds: new []{101})) {
                    return new State다리Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리Cinematic03 : TriggerState {
            internal State다리Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 601, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 8005, spawnIds: new []{101})) {
                    return new State다리StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리StopCinematic : TriggerState {
            internal State다리StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 101, script: "$63000006_CS__TUTORIAL01__8$", arg4: 3);
                context.SetEffect(triggerIds: new []{5080, 5064}, visible: false);
                context.SetEffect(triggerIds: new []{5011, 5012, 5013, 5014, 5015}, visible: true);
                context.ShowGuideSummary(entityId: 10010020, textId: 10010020);
                context.SetEffect(triggerIds: new []{5050, 5052}, visible: true);
            }

            public override TriggerState? Execute() {
                return new State다리붕괴01(context);
            }

            public override void OnExit() { }
        }

        private class State다리붕괴01 : TriggerState {
            internal State다리붕괴01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9003})) {
                    return new State다리붕괴02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetMesh(triggerIds: new []{3004}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3002, 3003}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.HideGuideSummary(entityId: 10010020);
                context.SetEffect(triggerIds: new []{5050, 5052, 5011, 5012, 5013, 5014, 5015}, visible: false);
            }
        }

        private class State다리붕괴02 : TriggerState {
            internal State다리붕괴02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{902, 906}, enabled: true);
                context.SetEffect(triggerIds: new []{5090}, visible: true);
            }

            public override TriggerState? Execute() {
                return new State다리붕괴03(context);
            }

            public override void OnExit() { }
        }

        private class State다리붕괴03 : TriggerState {
            internal State다리붕괴03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{900, 904, 901, 905}, enabled: true);
            }

            public override TriggerState? Execute() {
                return new State다리붕괴04(context);
            }

            public override void OnExit() { }
        }

        private class State다리붕괴04 : TriggerState {
            internal State다리붕괴04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{903}, enabled: true);
            }

            public override TriggerState? Execute() {
                return new State다리붕괴05(context);
            }

            public override void OnExit() { }
        }

        private class State다리붕괴05 : TriggerState {
            internal State다리붕괴05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{907}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9004})) {
                    return new State수영안내01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetSkill(triggerIds: new []{901, 902, 903}, enabled: false);
                context.SetMesh(triggerIds: new []{3001, 3004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }
        }

        private class State수영안내01 : TriggerState {
            internal State수영안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "30", seconds: 1);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetEffect(triggerIds: new []{5090}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "30")) {
                    return new State수영안내02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State수영안내02 : TriggerState {
            internal State수영안내02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "31", seconds: 4);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$63000006_CS__TUTORIAL01__9$", arg4: 3);
                context.SetEffect(triggerIds: new []{5065}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "31")) {
                    return new State수영안내03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State수영안내03 : TriggerState {
            internal State수영안내03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "32", seconds: 3);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$63000006_CS__TUTORIAL01__10$", arg4: 3);
                context.SetEffect(triggerIds: new []{5065}, visible: false);
                context.SetEffect(triggerIds: new []{5066}, visible: true);
                context.SetSkip(state: new StateIshura교체(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "32")) {
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
                context.SetEffect(triggerIds: new []{5050, 5020, 5021, 5022, 5023, 5024, 5025, 5026, 5027, 5028}, visible: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_1003");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 8006, spawnIds: new []{101})) {
                    return new StateCinematic05종료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{5066}, visible: false);
            }
        }

        private class StateCinematic05종료 : TriggerState {
            internal StateCinematic05종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9010, 9011, 9012, 9013, 9014, 9015})) {
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
                context.SetEffect(triggerIds: new []{5050}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9006})) {
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
                context.SetEffect(triggerIds: new []{5050, 5040}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9005})) {
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
                context.SetEffect(triggerIds: new []{5050, 5041, 5042, 5043, 5044, 5045, 5046, 5047, 5048}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9020})) {
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
                context.SetEffect(triggerIds: new []{5050}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9021})) {
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
                context.SetEffect(triggerIds: new []{5050}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9030}, questIds: new []{90000410}, questStates: new byte[]{1})) {
                    return new StatePortalCreation01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10010060);
                context.SetEffect(triggerIds: new []{5040, 5041, 5042, 5043, 5044, 5045, 5046, 5020, 5021, 5022, 5023, 5024, 5025, 5026, 5027, 5028}, visible: false);
            }
        }

        private class StatePortalCreation01 : TriggerState {
            internal StatePortalCreation01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "35", seconds: 1);
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.GuideEvent(eventId: 10010080);
                context.ShowGuideSummary(entityId: 10010070, textId: 10010070);
                context.SetEffect(triggerIds: new []{5050}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "35")) {
                    return new StateIshuraExit01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshuraExit01 : TriggerState {
            internal StateIshuraExit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 102, script: "$63000006_CS__TUTORIAL01__11$", arg4: 3);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_1004");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 8008, spawnIds: new []{102})) {
                    return new StateIshuraExit02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{5050}, visible: false);
            }
        }

        private class StateIshuraExit02 : TriggerState {
            internal StateIshuraExit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{102});
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9040})) {
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
                context.SetEffect(triggerIds: new []{5047, 5048}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
