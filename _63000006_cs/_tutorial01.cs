using System;

namespace Maple2.Trigger._63000006_cs {
    public static class _tutorial01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "Guide");
                context.SetPortal(arg1: 1, arg2: true, arg3: false, arg4: true);
                context.SetSkill(arg1: new int[] {900}, arg2: false);
                context.SetSkill(arg1: new int[] {901}, arg2: false);
                context.SetSkill(arg1: new int[] {902}, arg2: false);
                context.SetSkill(arg1: new int[] {903}, arg2: false);
                context.SetSkill(arg1: new int[] {904}, arg2: false);
                context.SetSkill(arg1: new int[] {905}, arg2: false);
                context.SetSkill(arg1: new int[] {906}, arg2: false);
                context.SetSkill(arg1: new int[] {907}, arg2: false);
                context.SetMesh(arg1: new int[] {3000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3003}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {5011}, arg2: false);
                context.SetEffect(arg1: new int[] {5012}, arg2: false);
                context.SetEffect(arg1: new int[] {5013}, arg2: false);
                context.SetEffect(arg1: new int[] {5014}, arg2: false);
                context.SetEffect(arg1: new int[] {5015}, arg2: false);
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5012}, arg2: false);
                context.SetEffect(arg1: new int[] {5013}, arg2: false);
                context.SetEffect(arg1: new int[] {5020}, arg2: false);
                context.SetEffect(arg1: new int[] {5021}, arg2: false);
                context.SetEffect(arg1: new int[] {5022}, arg2: false);
                context.SetEffect(arg1: new int[] {5023}, arg2: false);
                context.SetEffect(arg1: new int[] {5024}, arg2: false);
                context.SetEffect(arg1: new int[] {5025}, arg2: false);
                context.SetEffect(arg1: new int[] {5026}, arg2: false);
                context.SetEffect(arg1: new int[] {5027}, arg2: false);
                context.SetEffect(arg1: new int[] {5028}, arg2: false);
                context.SetEffect(arg1: new int[] {5040}, arg2: false);
                context.SetEffect(arg1: new int[] {5041}, arg2: false);
                context.SetEffect(arg1: new int[] {5042}, arg2: false);
                context.SetEffect(arg1: new int[] {5043}, arg2: false);
                context.SetEffect(arg1: new int[] {5044}, arg2: false);
                context.SetEffect(arg1: new int[] {5045}, arg2: false);
                context.SetEffect(arg1: new int[] {5046}, arg2: false);
                context.SetEffect(arg1: new int[] {5047}, arg2: false);
                context.SetEffect(arg1: new int[] {5048}, arg2: false);
                context.SetEffect(arg1: new int[] {5050}, arg2: false);
                context.SetEffect(arg1: new int[] {5051}, arg2: false);
                context.SetEffect(arg1: new int[] {5052}, arg2: false);
                context.SetEffect(arg1: new int[] {5060}, arg2: false);
                context.SetEffect(arg1: new int[] {5061}, arg2: false);
                context.SetEffect(arg1: new int[] {5062}, arg2: false);
                context.SetEffect(arg1: new int[] {5063}, arg2: false);
                context.SetEffect(arg1: new int[] {5064}, arg2: false);
                context.SetEffect(arg1: new int[] {5065}, arg2: false);
                context.SetEffect(arg1: new int[] {5066}, arg2: false);
                context.SetEffect(arg1: new int[] {5080}, arg2: false);
                context.SetEffect(arg1: new int[] {5090}, arg2: false);
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9000})) {
                    context.State = new State영상준비_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State영상준비_01 : TriggerState {
            internal State영상준비_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State영상재생_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State영상재생_01 : TriggerState {
            internal State영상재생_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: @"common\Common_Opening.usm", movieID: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State룬블영상준비_01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 190000)) {
                    context.State = new State룬블영상준비_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State룬블영상준비_01 : TriggerState {
            internal State룬블영상준비_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State룬블영상재생_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State룬블영상재생_01 : TriggerState {
            internal State룬블영상재생_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: @"common\RuneBlader_Intro.usm", movieID: 2);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "2")) {
                    context.State = new State룬블영상완료_01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 30000)) {
                    context.State = new State룬블영상완료_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State룬블영상완료_01 : TriggerState {
            internal State룬블영상완료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State키타입설정안내01(context);
                    return;
                }

                if (context.UserDetected(arg1: new int[] {9050,9051,9052,9053})) {
                    context.State = new State로딩딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State키타입설정안내01 : TriggerState {
            internal State키타입설정안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuideEvent(eventID: 10010005);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "Guide", arg2: "IsTriggerEvent", arg3: "10010009")) {
                    context.State = new State플레이준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State플레이준비 : TriggerState {
            internal State플레이준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 10010001, textID: 10010001);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9050,9051,9052,9053})) {
                    context.State = new State로딩딜레이(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10010001);
            }
        }

        private class State로딩딜레이 : TriggerState {
            internal State로딩딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State기상준비01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기상준비01 : TriggerState {
            internal State기상준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 1);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_999");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State기상대화01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기상대화01 : TriggerState {
            internal State기상대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 4);
                context.SetEffect(arg1: new int[] {5060}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$63000006_CS__TUTORIAL01__0$", arg4: 4);
                context.SetSkip(arg1: "움직이기01");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State움직이기01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State움직이기01 : TriggerState {
            internal State움직이기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetEffect(arg1: new int[] {5050}, arg2: true);
                context.ShowGuideSummary(entityID: 10010000, textID: 10010000);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {6001})) {
                    context.State = new State움직이기02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {5060}, arg2: false);
            }
        }

        private class State움직이기02 : TriggerState {
            internal State움직이기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_998");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {6000})) {
                    context.State = new State이동완료01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {5051}, arg2: true);
                context.HideGuideSummary(entityID: 10010000);
            }
        }

        private class State이동완료01 : TriggerState {
            internal State이동완료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1000");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State이동전대화01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {5050}, arg2: false);
            }
        }

        private class State이동전대화01 : TriggerState {
            internal State이동전대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State이동전대화02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동전대화02 : TriggerState {
            internal State이동전대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 4);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$63000006_CS__TUTORIAL01__1$", arg4: 3);
                context.SetEffect(arg1: new int[] {5061}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State이동전대화03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동전대화03 : TriggerState {
            internal State이동전대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 4);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$63000006_CS__TUTORIAL01__2$", arg4: 3);
                context.SetEffect(arg1: new int[] {5061}, arg2: false);
                context.SetEffect(arg1: new int[] {5062}, arg2: true);
                context.SetSkip(arg1: "미니맵가이드01");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State미니맵가이드01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State미니맵가이드01 : TriggerState {
            internal State미니맵가이드01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuideEvent(eventID: 10010010);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "Guide", arg2: "IsTriggerEvent", arg3: "10010020")) {
                    context.State = new State이슈라이동01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라이동01 : TriggerState {
            internal State이슈라이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 3);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$63000006_CS__TUTORIAL01__3$", arg4: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State이슈라이동02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라이동02 : TriggerState {
            internal State이슈라이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 1);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1001");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    context.State = new State이슈라이동03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라이동03 : TriggerState {
            internal State이슈라이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "12", arg2: 4);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$63000006_CS__TUTORIAL01__4$", arg4: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    context.State = new State이슈라이동04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라이동04 : TriggerState {
            internal State이슈라이동04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "13", arg2: 4);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$63000006_CS__TUTORIAL01__5$", arg4: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "13")) {
                    context.State = new State이슈라이동05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라이동05 : TriggerState {
            internal State이슈라이동05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "14", arg2: 4);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$63000006_CS__TUTORIAL01__6$", arg4: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "14")) {
                    context.State = new State다리연출준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리연출준비 : TriggerState {
            internal State다리연출준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 8002, arg2: new int[] {101})) {
                    context.State = new State다리연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리연출01 : TriggerState {
            internal State다리연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 4);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$63000006_CS__TUTORIAL01__7$", arg4: 3);
                context.SetEffect(arg1: new int[] {5064}, arg2: true);
                context.SetSkip(arg1: "다리연출02");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    context.State = new State다리연출02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class State다리연출02 : TriggerState {
            internal State다리연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: true);
                context.SetEffect(arg1: new int[] {5080}, arg2: true);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1002");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 8004, arg2: new int[] {101})) {
                    context.State = new State다리연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리연출03 : TriggerState {
            internal State다리연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 8005, arg2: new int[] {101})) {
                    context.State = new State다리연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리연출종료 : TriggerState {
            internal State다리연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$63000006_CS__TUTORIAL01__8$", arg4: 3);
                context.SetEffect(arg1: new int[] {5080}, arg2: false);
                context.SetEffect(arg1: new int[] {5064}, arg2: false);
                context.SetEffect(arg1: new int[] {5011}, arg2: true);
                context.SetEffect(arg1: new int[] {5012}, arg2: true);
                context.SetEffect(arg1: new int[] {5013}, arg2: true);
                context.SetEffect(arg1: new int[] {5014}, arg2: true);
                context.SetEffect(arg1: new int[] {5015}, arg2: true);
                context.ShowGuideSummary(entityID: 10010020, textID: 10010020);
                context.SetEffect(arg1: new int[] {5050}, arg2: true);
                context.SetEffect(arg1: new int[] {5052}, arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State다리붕괴01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리붕괴01 : TriggerState {
            internal State다리붕괴01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9003})) {
                    context.State = new State다리붕괴02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetMesh(arg1: new int[] {3004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.HideGuideSummary(entityID: 10010020);
                context.SetEffect(arg1: new int[] {5050}, arg2: false);
                context.SetEffect(arg1: new int[] {5052}, arg2: false);
                context.SetEffect(arg1: new int[] {5011}, arg2: false);
                context.SetEffect(arg1: new int[] {5012}, arg2: false);
                context.SetEffect(arg1: new int[] {5013}, arg2: false);
                context.SetEffect(arg1: new int[] {5014}, arg2: false);
                context.SetEffect(arg1: new int[] {5015}, arg2: false);
            }
        }

        private class State다리붕괴02 : TriggerState {
            internal State다리붕괴02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {902}, arg2: true);
                context.SetSkill(arg1: new int[] {906}, arg2: true);
                context.SetEffect(arg1: new int[] {5090}, arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State다리붕괴03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리붕괴03 : TriggerState {
            internal State다리붕괴03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {900}, arg2: true);
                context.SetSkill(arg1: new int[] {904}, arg2: true);
                context.SetSkill(arg1: new int[] {901}, arg2: true);
                context.SetSkill(arg1: new int[] {905}, arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State다리붕괴04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리붕괴04 : TriggerState {
            internal State다리붕괴04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {903}, arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State다리붕괴05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리붕괴05 : TriggerState {
            internal State다리붕괴05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {907}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9004})) {
                    context.State = new State수영안내01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetSkill(arg1: new int[] {901}, arg2: false);
                context.SetSkill(arg1: new int[] {902}, arg2: false);
                context.SetSkill(arg1: new int[] {903}, arg2: false);
                context.SetMesh(arg1: new int[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }
        }

        private class State수영안내01 : TriggerState {
            internal State수영안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "30", arg2: 1);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetEffect(arg1: new int[] {5090}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    context.State = new State수영안내02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State수영안내02 : TriggerState {
            internal State수영안내02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "31", arg2: 4);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$63000006_CS__TUTORIAL01__9$", arg4: 3);
                context.SetEffect(arg1: new int[] {5065}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "31")) {
                    context.State = new State수영안내03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State수영안내03 : TriggerState {
            internal State수영안내03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "32", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$63000006_CS__TUTORIAL01__10$", arg4: 3);
                context.SetEffect(arg1: new int[] {5065}, arg2: false);
                context.SetEffect(arg1: new int[] {5066}, arg2: true);
                context.SetSkip(arg1: "이슈라교체");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "32")) {
                    context.State = new State이슈라교체(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class State이슈라교체 : TriggerState {
            internal State이슈라교체(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 10010030, textID: 10010030);
                context.SetEffect(arg1: new int[] {5050}, arg2: true);
                context.SetEffect(arg1: new int[] {5020}, arg2: true);
                context.SetEffect(arg1: new int[] {5021}, arg2: true);
                context.SetEffect(arg1: new int[] {5022}, arg2: true);
                context.SetEffect(arg1: new int[] {5023}, arg2: true);
                context.SetEffect(arg1: new int[] {5024}, arg2: true);
                context.SetEffect(arg1: new int[] {5025}, arg2: true);
                context.SetEffect(arg1: new int[] {5026}, arg2: true);
                context.SetEffect(arg1: new int[] {5027}, arg2: true);
                context.SetEffect(arg1: new int[] {5028}, arg2: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1003");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 8006, arg2: new int[] {101})) {
                    context.State = new State연출05종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {5066}, arg2: false);
            }
        }

        private class State연출05종료 : TriggerState {
            internal State연출05종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9010,9011,9012,9013,9014,9015})) {
                    context.State = new State사다리유도01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10010030);
            }
        }

        private class State사다리유도01 : TriggerState {
            internal State사다리유도01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 10010020, textID: 10010020);
                context.SetEffect(arg1: new int[] {5050}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9006})) {
                    context.State = new State사다리유도02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10010020);
            }
        }

        private class State사다리유도02 : TriggerState {
            internal State사다리유도02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 10010040, textID: 10010040);
                context.SetEffect(arg1: new int[] {5050}, arg2: true);
                context.SetEffect(arg1: new int[] {5040}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9005})) {
                    context.State = new State언덕유도01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10010040);
            }
        }

        private class State언덕유도01 : TriggerState {
            internal State언덕유도01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 10010020, textID: 10010020);
                context.SetEffect(arg1: new int[] {5050}, arg2: true);
                context.SetEffect(arg1: new int[] {5041}, arg2: true);
                context.SetEffect(arg1: new int[] {5042}, arg2: true);
                context.SetEffect(arg1: new int[] {5043}, arg2: true);
                context.SetEffect(arg1: new int[] {5044}, arg2: true);
                context.SetEffect(arg1: new int[] {5045}, arg2: true);
                context.SetEffect(arg1: new int[] {5046}, arg2: true);
                context.SetEffect(arg1: new int[] {5047}, arg2: true);
                context.SetEffect(arg1: new int[] {5048}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9020})) {
                    context.State = new State언덕유도02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10010020);
            }
        }

        private class State언덕유도02 : TriggerState {
            internal State언덕유도02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 10010050, textID: 10010050);
                context.SetEffect(arg1: new int[] {5050}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9021})) {
                    context.State = new State퀘스트수락유도01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10010050);
            }
        }

        private class State퀘스트수락유도01 : TriggerState {
            internal State퀘스트수락유도01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 10010060, textID: 10010060);
                context.SetEffect(arg1: new int[] {5050}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9030}, arg2: new int[] {90000410},
                    arg3: new byte[] {1})) {
                    context.State = new State포털생성01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10010060);
                context.SetEffect(arg1: new int[] {5040}, arg2: false);
                context.SetEffect(arg1: new int[] {5041}, arg2: false);
                context.SetEffect(arg1: new int[] {5042}, arg2: false);
                context.SetEffect(arg1: new int[] {5043}, arg2: false);
                context.SetEffect(arg1: new int[] {5044}, arg2: false);
                context.SetEffect(arg1: new int[] {5045}, arg2: false);
                context.SetEffect(arg1: new int[] {5046}, arg2: false);
                context.SetEffect(arg1: new int[] {5020}, arg2: false);
                context.SetEffect(arg1: new int[] {5021}, arg2: false);
                context.SetEffect(arg1: new int[] {5022}, arg2: false);
                context.SetEffect(arg1: new int[] {5023}, arg2: false);
                context.SetEffect(arg1: new int[] {5024}, arg2: false);
                context.SetEffect(arg1: new int[] {5025}, arg2: false);
                context.SetEffect(arg1: new int[] {5026}, arg2: false);
                context.SetEffect(arg1: new int[] {5027}, arg2: false);
                context.SetEffect(arg1: new int[] {5028}, arg2: false);
            }
        }

        private class State포털생성01 : TriggerState {
            internal State포털생성01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "35", arg2: 1);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.GuideEvent(eventID: 10010080);
                context.ShowGuideSummary(entityID: 10010070, textID: 10010070);
                context.SetEffect(arg1: new int[] {5050}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "35")) {
                    context.State = new State이슈라퇴장01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라퇴장01 : TriggerState {
            internal State이슈라퇴장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$63000006_CS__TUTORIAL01__11$", arg4: 3);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_1004");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 8008, arg2: new int[] {102})) {
                    context.State = new State이슈라퇴장02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {5050}, arg2: false);
            }
        }

        private class State이슈라퇴장02 : TriggerState {
            internal State이슈라퇴장02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {102});
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {9040})) {
                    context.State = new State맵이동완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State맵이동완료 : TriggerState {
            internal State맵이동완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 10010070);
                context.SetEffect(arg1: new int[] {5047}, arg2: false);
                context.SetEffect(arg1: new int[] {5048}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}